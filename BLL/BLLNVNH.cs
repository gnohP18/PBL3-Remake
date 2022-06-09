using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
namespace BLL
{
    public class BLLNVNH : BLL
    {
        private static BLLNVNH _Instance;
        public static BLLNVNH Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLLNVNH();
                return _Instance;
            }
            private set { }
        }
        private BLLNVNH()
        {

        }
        #region Bàn
        public List<Ban> GetMainBanByTinhTrangBanVaTang(int st, int fl)
        {
            if (st == 0)
            {
                return dALQLNH.Bans.Where(p => (p.Tang == fl && p.TinhTrangBan == 0)).ToList();
            }
            else
            {
                List<Ban> list;
                if (st == -1)
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
        public string GetAllCollabTable(Ban tb, int ttban, string txt)
        {
            if (tb.ID_Ban == tb.TinhTrangBan || tb.TinhTrangBan == 0)
            {
                Console.WriteLine(txt);
                return txt;
            }
            else
            {
                Console.WriteLine(txt);
                return GetAllCollabTable(GetBanByID_Ban(tb.TinhTrangBan), ttban, txt);
            }
        }

        public int FindMainTable(Ban tb)
        {
            if (dALQLNH.Bans.Where(s => s.TinhTrangBan == tb.ID_Ban && s.ID_Ban != s.TinhTrangBan).FirstOrDefault() == null)
            {
                return tb.ID_Ban;
            }
            else
            {
                return FindMainTable(dALQLNH.Bans.Where(s => s.TinhTrangBan == tb.ID_Ban && s.ID_Ban != s.TinhTrangBan).FirstOrDefault());
            }
        }
        public string GetAllMainTable(Ban tb, string txt)
        {
            if (dALQLNH.Bans.Where(s => s.TinhTrangBan == tb.ID_Ban && s.ID_Ban != s.TinhTrangBan).FirstOrDefault() == null)
            {
                return txt;
            }
            else
            {
                Ban bn = dALQLNH.Bans.Where(s => s.TinhTrangBan == tb.ID_Ban && s.ID_Ban != s.TinhTrangBan).FirstOrDefault();
                txt = txt + " " + bn.TenBan.ToString();
                return GetAllMainTable(bn, txt);
            }
        }

        public List<ChiTietBan> GetAllDetailTableByStatus(int st)
        {
            List<ChiTietBan> list = new List<ChiTietBan>();
            if (st == 3)
            {
                foreach (ChiTietBan i in dALQLNH.ChiTietBans)
                {
                    list.Add(i);
                }
            }
            else
            {
                foreach (ChiTietBan i in dALQLNH.ChiTietBans)
                {
                    if (i.TinhTrang == st)
                    {
                        list.Add(i);
                    }
                }
            }
            return list;
        }
        public ChiTietBan GetDetailTableByID(int idctb)
        {
            return dALQLNH.ChiTietBans.Where(i => i.ID_ChiTietBan == idctb).FirstOrDefault();
        }
        #endregion
        #region Món ăn
        public List<MonAn> GetMonAn(int ID_LoaiMonAn, string txt, int TrangThai)
        {
            return dALQLNH.MonAns.Where(p => p.ID_LoaiMonAn == ID_LoaiMonAn && p.TrangThai == TrangThai && p.TenMonAn.Contains(txt)).ToList();
        }
        public List<MonAn_View> GetListMonAnByIDBan(int ID_Ban)
        {
            List<MonAn_View> data = new List<MonAn_View>();
            var groupMonAn = dALQLNH.ChiTietBans.GroupBy(s => s.ID_Ban).Where(g => g.Key == ID_Ban);
            foreach (var childGroup in groupMonAn)
            {
                foreach (ChiTietBan i in childGroup)
                {
                    MonAn monAn = dALQLNH.MonAns.Find(i.ID_MonAn);
                    bool checkMonAnExisted = false;
                    foreach (MonAn_View j in data)
                    {
                        if (j.ID_MonAn == monAn.ID_MonAn)
                        {
                            j.SoLuong += i.SoLuong;
                            j.ThanhTien = j.SoLuong * monAn.ThanhTien;
                            checkMonAnExisted = true;
                            continue;
                        }
                    }
                    if (!checkMonAnExisted)
                        data.Add(new MonAn_View { ID_MonAn = monAn.ID_MonAn, TenMonAn = monAn.TenMonAn, SoLuong = i.SoLuong, ThanhTien = monAn.ThanhTien });
                }
            }
            return data;
        }
        public void ChangeStatusDishByID(int id)
        {
            foreach (ChiTietBan i in dALQLNH.ChiTietBans)
            {
                if (i.ID_ChiTietBan == id)
                {
                    i.TinhTrang = 1;
                    break;
                }
            }
            dALQLNH.SaveChanges();
        }
        #endregion
        #region Khác
        public void Order(List<MonAn_View> lt, int Idtable)
        {

            foreach (MonAn_View item in lt)
            {
                //Add detail table
                dALQLNH.ChiTietBans.Add(new ChiTietBan
                {
                    ID_ChiTietBan = GetNewIDChiTietBan(),
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
        #endregion


        //public int checkLoginCustomer(string username, string password)
        //{
        //    User user = (User)dALQLNH.Users.Where(u => u.Username == username && u.Password == password).FirstOrDefault();
        //    if (user == null) return -1;
        //    if (user.ID_ChucVu == 1) return 1;
        //    if (user.ID_ChucVu == 2) return -2;
        //    if (user.ID_ChucVu == 3)
        //    {
        //        int dateNowHashCode = DateTime.Now.GetHashCode();
        //        List<ChiTietCaLam> listChiTietCaLam = dALQLNH.ChiTietCaLams.Where(s => s.ID_User == user.ID_User).ToList();
        //        List<string> strCaLam = new List<string>();
        //        foreach (ChiTietCaLam i in listChiTietCaLam)
        //        {
        //            strCaLam.Add(dALQLNH.CaLams.Find(i.ID_CaLam).LichCaLam);
        //        }
        //        foreach (string i in strCaLam)
        //        {

        //        }
        //    }
        //    return 1;
        //}
    }
}

