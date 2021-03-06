using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class BanBLL : BLL
    {
        private static BanBLL _Instance;
        public static BanBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BanBLL();
                return _Instance;
            }
            private set { }
        }
        private BanBLL()
        {

        }
        public List<Ban> GetAllTableByFloor(int fl)
        {
            List<Ban> bans = new List<Ban>();
            foreach (Ban i in dALQLNH.Bans)
            {
                if (i.Tang == fl)
                    bans.Add(i);
            }
            return bans;
        }
        public List<Table_view> GetAllTable_viewByFloorAndStatus(int Status, int Floor)
        {
            List<Table_view> list = new List<Table_view>();
            foreach (Ban ban in GetMainBanByTinhTrangBanVaTang(Status, Floor))
            {
                Table_view tb = new Table_view();
                tb.ID_Table = ban.ID_Ban;
                tb.Floor = "Floor " + Floor.ToString();
                tb.NumberOfDish = GetAllDetailTableByID_Table(ban.ID_Ban).Count();
                tb.NameTable = ban.TenBan;
                list.Add(tb);
            }
            return list;
        }
        public List<ChiTietBan> GetAllDetailTableByID_Table(int ID_Table)
        {
            List<ChiTietBan> list = new List<ChiTietBan>();
            foreach (ChiTietBan i in dALQLNH.ChiTietBans)
            {
                if (ID_Table == i.ID_Ban)
                {
                    list.Add(i);
                }
            }
            return list;
        }
        public List<Ban> GetMainBanByTinhTrangBanVaTang(int st, int fl)
        {
            if (st == 1)
            {
                return dALQLNH.Bans.Where(p => (p.Tang == fl && p.TinhTrangBan == 0)).ToList();
            }
            else
            {
                List<Ban> list;
                if (st == 0)
                    list = new List<Ban>(dALQLNH.Bans.Where(p => p.Tang == fl).ToList());
                else
                {
                    list = new List<Ban>(dALQLNH.Bans.Where(p => (p.Tang == fl && p.TinhTrangBan != 0)).ToList());
                }
                foreach (Ban i in list.ToList())
                {
                    if (dALQLNH.Bans.Where(p => (p.TinhTrangBan == i.ID_Ban && p.TinhTrangBan != p.ID_Ban)).FirstOrDefault() != null)
                    {
                        list.Remove(i);
                    }
                }
                return list;
            }
        }
        public Ban GetBanByID_Ban(int id)
        {
            return dALQLNH.Bans.Where(p => p.ID_Ban == id).FirstOrDefault();
        }
        public int GetNewIDChiTietBan()
        {
            int id = 1;
            foreach (ChiTietBan i in dALQLNH.ChiTietBans)
            {
                if (id != i.ID_ChiTietBan)
                {
                    return id;
                }
                id++;
            }
            return id;
        }
        public void ChangeStatusTable(int idtatable, int idbanghep)
        {
            var table = dALQLNH.Bans.Where(p => p.ID_Ban == idtatable).FirstOrDefault();
            table.TinhTrangBan = idbanghep;
            dALQLNH.SaveChanges();
        }

        public void SetCollabTable(Ban MainBan, int IDCollabBan)
        {
            if (MainBan.ID_Ban == MainBan.TinhTrangBan || MainBan.TinhTrangBan == 0)
            {
                Ban banCollab = GetBanByID_Ban(IDCollabBan);
                MainBan.TinhTrangBan = IDCollabBan;
                if (banCollab.TinhTrangBan == 0)
                    banCollab.TinhTrangBan = IDCollabBan;
                else
                {
                    List<ChiTietBan> chiTietBans = dALQLNH.ChiTietBans.Where(s => s.ID_Ban == IDCollabBan).ToList();
                    foreach (ChiTietBan i in chiTietBans)
                    {
                        i.ID_Ban = MainBan.ID_Ban;
                    }
                }
                dALQLNH.SaveChanges();
            }
            else if (MainBan.ID_Ban != MainBan.TinhTrangBan)
            {
                SetCollabTable(GetBanByID_Ban(MainBan.TinhTrangBan), IDCollabBan);
            }
        }


        public List<ChiTietBan_View> GetAllChiTietBan_ViewByStatus(int st)
        {
            List<ChiTietBan_View> data = new List<ChiTietBan_View>();
            foreach (ChiTietBan i in dALQLNH.ChiTietBans.Where(s => s.TinhTrang == st).ToList())
            {
                data.Add(new ChiTietBan_View
                {
                    ID_ChiTietBan = i.ID_ChiTietBan,
                    ID_Ban = i.ID_Ban,
                    TenBan = i.Ban.TenBan,
                    TenMonAn = i.MonAn.TenMonAn,
                    SoLuong = i.SoLuong,
                    TinhTrang = i.TinhTrang,
                });
            }
            return data.OrderBy(s => s.ID_Ban).ToList();
        }
        public ChiTietBan GetDetailTableByID(int idctb)
        {
            return dALQLNH.ChiTietBans.Where(i => i.ID_ChiTietBan == idctb).FirstOrDefault();
        }
        public void Order(List<MonAn_View> lt, int Idtable)
        {

            foreach (MonAn_View item in lt)
            {
                //Add detail table
                dALQLNH.ChiTietBans.Add(new ChiTietBan
                {
                    ID_ChiTietBan = BanBLL.Instance.GetNewIDChiTietBan(),
                    ID_Ban = Idtable,
                    ID_MonAn = item.ID_MonAn,
                    SoLuong = item.SoLuong,
                    TinhTrang = 0
                });
                //Get material from warehouse
                List<ChiTietMonAn> listChiTietMonAn = dALQLNH.ChiTietMonAns.Where(s => s.ID_MonAn == item.ID_MonAn).ToList();
                foreach (ChiTietMonAn chiTietMonAn in listChiTietMonAn)
                {
                    float luong = chiTietMonAn.Luong * item.SoLuong;
                    List<Kho> khos = dALQLNH.Khoes.Where(s => s.ID_NguyenLieu == chiTietMonAn.ID_NguyenLieu && s.NgayHetHan > DateTime.Now).OrderBy(s => s.NgayHetHan).ToList();
                    foreach (Kho i in khos)
                    {
                        if (i.LuongTonKho >= luong)
                        {
                            i.LuongTonKho -= luong;
                            break;
                        }
                        else
                        {
                            luong -= i.LuongTonKho;
                            i.LuongTonKho = 0;
                        }
                    }
                }
                dALQLNH.SaveChanges();
            }
        }
        public void ClearAllMonOfBan(int ID_Ban)
        {
            foreach(ChiTietBan i in dALQLNH.ChiTietBans.Where(s=>s.ID_Ban == ID_Ban).ToList())
            {
                dALQLNH.ChiTietBans.Remove(i);
                dALQLNH.SaveChanges();
            }
        }
        public void SetEmptyBan(int ID_Ban)
        {
            Ban ban = dALQLNH.Bans.Find(ID_Ban);
            if (ban.TinhTrangBan != ID_Ban) SetEmptyBan(dALQLNH.Bans.Find(ban.TinhTrangBan).ID_Ban);
            dALQLNH.Bans.Find(ID_Ban).TinhTrangBan = 0;
            dALQLNH.SaveChanges();
        }
        public void ExecuteFood(int ID_ChiTietBan)
        {
            dALQLNH.ChiTietBans.Find(ID_ChiTietBan).TinhTrang = 1;
            dALQLNH.SaveChanges();
        }
    }
}
