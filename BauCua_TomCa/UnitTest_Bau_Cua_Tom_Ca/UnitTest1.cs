using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTest_Bau_Cua_Tom_Ca
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_kiemTra_textBox_nhapSo_TC1()
        {
            //--KIỂM TRA TEXTBOX CHỈ NHẬP SỐ
            //khởi tạo

            string test = "asdsd";

            //hành động
            bool mongdoi = true;

            //test
            bool thucte = BauCua_TomCa.Form1.kiemTra_textboxChiNhapSo(test);
            Assert.AreEqual(mongdoi, thucte);
        }
           [TestMethod]
        public void Test_kiemTra_textBox_nhapSo_TC2()
        {
            //--KIỂM TRA TEXTBOX CHỈ NHẬP SỐ
            //khởi tạo

            string test = "10000";

            //hành động
            bool mongdoi = true;

            //test
            bool thucte = BauCua_TomCa.Form1.kiemTra_textboxChiNhapSo(test);
            Assert.AreEqual(mongdoi, thucte);
        }

          [TestMethod]
           public void Test_kiemTra_tienCuocHienCo_TC1()
           {
               //--KIỂM TRA TIỀN CƯỢC HIỆN CÓ
               //khởi tạo

               double test=-2 ;

               //hành động
               bool mongdoi = true;

               //test
               bool thucte = BauCua_TomCa.Form1.kiemTra_tienHienCo(test);
               Assert.AreEqual(mongdoi, thucte);
           }
          [TestMethod]
          public void Test_kiemTra_tienCuocHienCo_TC2()
          {
              //--KIỂM TRA TIỀN CƯỢC HIỆN CÓ
              //khởi tạo

              double test = 10000;

              //hành động
              bool mongdoi = true;

              //test
              bool thucte = BauCua_TomCa.Form1.kiemTra_tienHienCo(test);
              Assert.AreEqual(mongdoi, thucte);
          }





          [TestMethod]
          public void Test_kiemTra_tienDatCuoc_lonHon_tienHienCo_TC1()
          {
              //--KIỂM TRA TIỀN ĐẶT CƯỢC LỚN HƠN TIỀN HIỆN CÓ
              //khởi tạo

              float test_tienDat = 0;
              float test_tienChoi = 0;
              //hành động
              bool mongdoi = true;

              //test
              bool thucte = BauCua_TomCa.Form1.kiemTra_tienDatCuoc_lonHon_tienHienCo(test_tienChoi, test_tienDat);
              Assert.AreEqual(mongdoi, thucte);
          }
          [TestMethod]
          public void Test_kiemTra_tienDatCuoc_lonHon_tienHienCo_TC2()
          {
              //--KIỂM TRA TIỀN ĐẶT CƯỢC LỚN HƠN TIỀN HIỆN CÓ
              //khởi tạo

              float test_tienDat = 100000;
              float test_tienChoi = 0;
              //hành động
              bool mongdoi = true;

              //test
              bool thucte = BauCua_TomCa.Form1.kiemTra_tienDatCuoc_lonHon_tienHienCo(test_tienChoi,test_tienDat);
              Assert.AreEqual(mongdoi, thucte);
          }

          [TestMethod]
          public void Test_kiemTra_tienDatCuoc_lonHon_tienHienCo_TC3()
          {
              //--KIỂM TRA TIỀN ĐẶT CƯỢC LỚN HƠN TIỀN HIỆN CÓ
              //khởi tạo

              float test_tienDat = 10000000;
              float test_tienChoi =0;
              //hành động
              bool mongdoi = true;

              //test
              bool thucte = BauCua_TomCa.Form1.kiemTra_tienDatCuoc_lonHon_tienHienCo(test_tienChoi, test_tienDat);
              Assert.AreEqual(mongdoi, thucte);
          }
          [TestMethod]
          public void Test_kiemTra_tienDatCuoc_lonHon_tienHienCo_TC4()
          {
              //--KIỂM TRA TIỀN ĐẶT CƯỢC LỚN HƠN TIỀN HIỆN CÓ
              //khởi tạo

              float test_tienDat = 1000;
              float test_tienChoi = 10000;
              //hành động
              bool mongdoi = true;

              //test
              bool thucte = BauCua_TomCa.Form1.kiemTra_tienDatCuoc_lonHon_tienHienCo(test_tienChoi, test_tienDat);
              Assert.AreEqual(mongdoi, thucte);
          }

    }
}
