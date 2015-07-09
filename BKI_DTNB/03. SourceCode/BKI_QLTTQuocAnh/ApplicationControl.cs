using System;
using System.Diagnostics;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using IP.Core.IPBusinessService;
using IP.Core.IPUserService;
using BKI_QLTTQuocAnh;
using Form_menu;
using BKI_QLTTQuocAnh.NghiepVu;



namespace BKI_QLTTQuocAnh
{
	#region Nhiệm vụ của Class
	//*********************************************************************************
	//*  Là khởi động và điều khiển dăng nhập mới vào  Hệ thống
	//*  - hiện thị form login
	//*  - nếu OK thì tạo context và hiện thị form main, User không muốn vào thì thoát ra
	//*  - nếu trở lại từ main theo kiểu login mới thì lại hiện thị form login
	//*  - nếu trở lại từ main theo kiểu "exit from system" thì thoát
	//*********************************************************************************
#endregion
   

    public class ApplicationControl
	{
        [STAThread]
		static void Main(){

            try
            {
                IP.Core.IPSystemAdmin.f101_Dang_Nhap v_frm_login_form = new f101_Dang_Nhap();
                US_HT_NGUOI_SU_DUNG v_us_user = new US_HT_NGUOI_SU_DUNG();
                CLoginInformation_302 v_obj_login_info = new CLoginInformation_302(v_us_user);
                DialogResult v_login_result = DialogResult.Cancel;
                bool v_UserWant2ExitFromSystem = false;
                IPConstants.HowUserWantTo_Exit_MainForm v_exitmode = IPConstants.HowUserWantTo_Exit_MainForm.ExitFromSystem;
                // Login lan 1
                v_frm_login_form.displayLogin(ref v_obj_login_info, ref v_login_result);
                if (v_login_result == DialogResult.Cancel)
                {
                    v_frm_login_form.Dispose();
                    v_frm_login_form.Close();
                    return;
                }
                v_frm_login_form.Dispose();
                while (!v_UserWant2ExitFromSystem)
                {
                    CAppContext_201.InitializeContext(v_obj_login_info);
                    CAppContext_201.LoadDecentralizationByUserLogin();
                    f388_main v_frm_main = new f388_main();
                    v_frm_main.display(ref v_exitmode);
                    v_frm_main.Dispose();
                    //f340_lap_phieu_thu v_frm = new f340_lap_phieu_thu();
                    //v_frm.display();
                    // sau main form hiện thì login hoặc thóat
                    switch (v_exitmode)
                    {
                        case IPConstants.HowUserWantTo_Exit_MainForm.ExitFromSystem:
                            v_UserWant2ExitFromSystem = true;
                            break;
                        case IPConstants.HowUserWantTo_Exit_MainForm.Login_As_DifferentUser:
                            // vào bằng user khác ( hoặc nhóm khác)
                            v_frm_login_form = new f101_Dang_Nhap();
                            v_frm_login_form.displayLogin(ref v_obj_login_info, ref v_login_result);
                            v_frm_login_form.Dispose();
                            break;
                        default:
                            // should never happens
                            Debug.Assert(false);
                            break;
                    }

                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
		}		
	}
}
