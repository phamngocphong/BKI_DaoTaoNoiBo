'Chu y :khi dung IPExcelWebReport de xuat bao cao qua web:
'Khi FormWin su dung phuong thuc :Export2Excel va Export2ExcelWithoutFixedRows
'thi phai gan i_b_show = true:->Huy Excel object
'   + Export2Excel(,,,true)
'   + Hoac Export2ExcelWithoutFixedRows(,,,true)
'Khi F5 Built Solution gap loi sau :
'----------------------
'Compiler Error Message: CS0006: Metadata file 'c:\windows\microsoft.net\framework\v1.1.4322\temporary asp.net files\serverreport\fd14593e\b1953e3a\assembly\dl2\4ffb0acd\003bff45_2679c501\c1.common.dll' could not be found
'Giai quyet bang cach sau :
'       Bat cua so Windows Task Manager (Ctrl + Alt + Delete)
'       End Process aspnet_wp.exe  
'   --> Built lai Solution
'----------------------
'Tung buoc tao Solution Web Report:
' 1. Tao Project WebForm :
'   + Them the <identity impersonate="true"/>  vao file Web.Config
'   + Goi duoc FormWin -> Add References System.Windows.Forms
' 2.
'
