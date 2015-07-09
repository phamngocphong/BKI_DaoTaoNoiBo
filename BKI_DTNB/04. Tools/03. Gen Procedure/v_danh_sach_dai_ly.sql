create view V_DANH_SACH_DAI_LY as
	select  
		t.DAI_LY_NAME,
		t.DIEN_THOAI,
		t.FAX,
		t.DIA_CHI,
		t.TRU_SO_CHINH_YN,
		d.ID_AUCTION,
		d.ID_DM_DAI_LY
from  DM_DAI_LY t , DAI_LY_AUCTION d
where t.ID = d.ID_DM_DAI_LY


