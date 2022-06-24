--------------------------------------------------------------------
--KELOMPOK 10------------
--M DANISH LUTHFI
--CHRISTOPER RICHARD SANTOSO
--------------------------------------------------------------------

/****** Object:  StoredProcedure [dbo].[sp_InsertFasilitas]    Script Date: 22/06/2022 11:20:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[sp_InsertFasilitas]
	@idFasilitas		VARCHAR	(10),
	@fs_desc		VARCHAR	(50),
	@fs_harga		money
AS
BEGIN
	INSERT INTO tblFasilitas
	VALUES(@idFasilitas,@fs_desc,@fs_harga)
END

/****** Object:  StoredProcedure [dbo].[sp_Insertkaryawan]    Script Date: 22/06/2022 11:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[sp_Insertkaryawan]
	@idKaryawan		VARCHAR	(10),
	@idRole			VARCHAR	(10),
	@kr_nama		VARCHAR	(50),
	@kr_alamat		VARCHAR (100),
	@kr_notelp		VARCHAR (16),
	@username		VARCHAR(20),
	@password		VARCHAR(10)
AS
BEGIN
	INSERT INTO tbKaryawan
	VALUES(@idKaryawan,@idRole,@kr_nama,@kr_alamat,@kr_notelp,@username,@password)
END

