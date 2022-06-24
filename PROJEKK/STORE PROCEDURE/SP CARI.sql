--------------------------------------------------------------------
--KELOMPOK 10------------
--M DANISH LUTHFI
--CHRISTOPER RICHARD SANTOSO
--------------------------------------------------------------------


/****** Object:  StoredProcedure [dbo].[sp_CariKaryawan]    Script Date: 22/06/2022 10:25:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[sp_CariKaryawan]
@cari		varchar(50)
AS
BEGIN
	SELECT * FROM tbKaryawan
	WHERE idKaryawan LIKE '%' +@cari +'%'
	or kr_nama LIKE '&' + @cari + '%'
	
END


/****** Object:  StoredProcedure [dbo].[sp_CariRole]    Script Date: 22/06/2022 10:47:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[sp_CariRole]
@idRole	VARCHAR	(10)
AS
BEGIN
	SELECT * FROM tblRoleKaryawan WHERE idRole =@idRole
END

/****** Object:  StoredProcedure [dbo].[sp_CariTipeKamar]    Script Date: 22/06/2022 10:47:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[sp_CariTipeKamar]
@idKamar	VARCHAR	(10)
AS
BEGIN
	SELECT * FROM tblTipeKamar WHERE idKamar =@idKamar
END

/****** Object:  StoredProcedure [dbo].[sp_CariUsername]    Script Date: 22/06/2022 10:48:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[sp_CariUsername]
@username		VARCHAR	(10)
AS
BEGIN
	SELECT * FROM tbKaryawan WHERE username = @username
END

