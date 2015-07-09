using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms.Layout;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System.Drawing;
using System.Collections;
using DevExpress.XtraTab.ViewInfo;

namespace GuiDev {
    public class TabAdd {

        /// <summary>
        /// Thêm các Tab Page vào ExtraTabControl
        /// </summary>
        /// <param name="ip_tab_control">Đây là thằng Control để điều khiển</param>
        /// <param name="ip_tab_page_name">Đây là các tab page</param>
        /// <param name="ip_tab_page_text_header">Đây là text hiển thị trên các tab</param>
        /// <param name="ip_form">Đây là Form muốn đút vào User Control</param>
        /// <param name="ip_user_control">Đây là user control muốn nhét vào</param>
        public void AddTab(XtraTabControl ip_tab_control
                                        , string ip_tab_page_name
                                        , string ip_tab_page_text_header
                                        , Form ip_form
                                        , UserControl ip_user_control) {
            /*Bước 1: Check xem Tab Page đã được mở chưa
                * Nếu mở rồi thì focus vào tab page đó*/
            foreach (XtraTabPage v_tab in ip_tab_control.TabPages) {
                if (v_tab.Name == ip_tab_page_name) {
                    ip_tab_control.SelectedTabPage = v_tab;
                    return;
                }
            }

            //Bước 2: Insert Tag Page
            //Tạo icon "x" để close Tab
            //ip_tab_control.ClosePageButtonShowMode = ClosePageButtonShowMode.InAllTabPageHeaders;
            //Khởi tạo 1 Tab Page
            XtraTabPage tab = new XtraTabPage();
            //Đặt tên cho tab
            tab.Name = ip_tab_page_name;
            // Tên của nó là đối số như đã nói ở trên
            tab.Text = ip_tab_page_text_header;
            // Dock tab fill
            ip_user_control.Dock = DockStyle.Fill;

            //Bước 3: Add Form vào user control
            ip_form.TopLevel = false;
            ip_form.FormBorderStyle = FormBorderStyle.None;
            ip_form.Visible = true;
            ip_form.Dock = DockStyle.Fill;
            ip_user_control.Controls.Add(ip_form);
            tab.Controls.Add(ip_user_control);

            //Bước 4: 
            ip_tab_control.TabPages.Add(tab);
            ip_tab_control.SelectedTabPage = tab;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ip_tab_control"></param>
        /// <param name="ip_tab_page_name"></param>
        /// <param name="ip_tab_page_text_header"></param>
        /// <param name="ip_form"></param>
        /// <param name="ip_user_control"></param>
        /// <param name="ip_focus">true nếu muốn focus, false nếu không muốn focus</param>
        public void AddTab(XtraTabControl ip_tab_control
                                        , string ip_tab_page_name
                                        , string ip_tab_page_text_header
                                        , Form ip_form
                                        , UserControl ip_user_control
                                        , Boolean ip_focus) {
            /*Bước 1: Check xem Tab Page đã được mở chưa
                * Nếu mở rồi thì focus vào tab page đó*/
            if (ip_focus == true) {
                foreach (XtraTabPage v_tab in ip_tab_control.TabPages) {
                    if (v_tab.Name == ip_tab_page_name) {
                        ip_tab_control.SelectedTabPage = v_tab;
                        return;
                    }
                }
            }

            //Bước 2: Insert Tag Page
            //Tạo icon "x" để close Tab
            //ip_tab_control.ClosePageButtonShowMode = ClosePageButtonShowMode.InAllTabPageHeaders;
            //Khởi tạo 1 Tab Page
            XtraTabPage tab = new XtraTabPage();
            //Đặt tên cho tab
            tab.Name = ip_tab_page_name;
            // Tên của nó là đối số như đã nói ở trên
            tab.Text = ip_tab_page_text_header;
            // Dock tab fill
            ip_user_control.Dock = DockStyle.Fill;

            //Bước 3: Add Form vào user control
            ip_form.TopLevel = false;
            ip_form.FormBorderStyle = FormBorderStyle.None;
            ip_form.Visible = true;
            ip_form.Dock = DockStyle.Fill;
            ip_user_control.Controls.Add(ip_form);
            tab.Controls.Add(ip_user_control);

            //Bước 4: 
            ip_tab_control.TabPages.Add(tab);
            ip_tab_control.SelectedTabPage = tab;
        }


        /// <summary>
        /// Hàm đặt trong Event Close Form để đóng tab hiện tại
        /// </summary>
        /// <param name="i_xtab">XtraTabControl</param>
        /// <param name="e">EventArgs</param>
        public void setCloseTabInEventCloseForm(XtraTabControl i_xtab, EventArgs e) {
            XtraTabPage tab = (e as ClosePageButtonEventArgs).Page as XtraTabPage;
            i_xtab.TabPages.Remove(tab);
        }

        /// <summary>
        /// Show nút x tắt tab
        /// </summary>
        /// <param name="i_xtab">XtraTabControl</param>
        /// <param name="i_mod">Kiểu button close</param>
        public void setCloseButtonTab(XtraTabControl i_xtab, ClosePageButtonShowMode i_mod) {
            i_xtab.ClosePageButtonShowMode = i_mod;
        }
    }


}
