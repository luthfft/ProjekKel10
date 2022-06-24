--------------------------------------------------------------------
--KELOMPOK 10------------
--M DANISH LUTHFI
--CHRISTOPER RICHARD SANTOSO
--------------------------------------------------------------------

/****** Object:  StoredProcedure [dbo].[sp_LoadFasilitas]    Script Date: 23/06/2022 14:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE[dbo].[sp_LoadFasilitas]
AS 
BEGIN
	SELECT idFasilitas,fs_desc,fs_harga FROM tblFasilitas
END

/****** Object:  StoredProcedure [dbo].[sp_Loadkar]    Script Date: 23/06/2022 14:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE[dbo].[sp_Loadkar]
AS 
BEGIN
		SELECT idKaryawan, nama_role, kr_nama, kr_alamat,kr_notelp,username,password FROM tbKaryawan
		INNER JOIN tblRoleKaryawan ON tbKaryawan.idRole = tblRoleKaryawan.idRole
END