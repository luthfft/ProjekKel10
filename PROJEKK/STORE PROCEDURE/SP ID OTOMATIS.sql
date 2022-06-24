--------------------------------------------------------------------
--KELOMPOK 10------------
--M DANISH LUTHFI
--CHRISTOPER RICHARD SANTOSO
--------------------------------------------------------------------


/****** Object:  StoredProcedure [dbo].[sp_IdFasilitas]    Script Date: 22/06/2022 10:58:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[sp_IdFasilitas]
AS
BEGIN
	SELECT MAX(Right( idFasilitas ,3)) + 1 AS idReturn FROM tblFasilitas
END


/****** Object:  StoredProcedure [dbo].[sp_Idkar]    Script Date: 22/06/2022 11:00:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[sp_Idkar]
AS
BEGIN
SELECT MAX(Right( idKaryawan ,3)) + 1 AS idReturn FROM tbKaryawan
END

/****** Object:  StoredProcedure [dbo].[sp_IdLaundry]    Script Date: 22/06/2022 11:15:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[sp_IdLaundry]
AS
BEGIN
	SELECT MAX(Right( idLaundry ,3)) + 1 AS idReturn FROM tblLaundry
END


/****** Object:  StoredProcedure [dbo].[sp_IdRole]    Script Date: 22/06/2022 11:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[sp_IdRole]
AS
BEGIN
	SELECT MAX(Right( idRole ,3)) + 1 AS idReturn FROM tblRoleKaryawan
END


/****** Object:  StoredProcedure [dbo].[sp_IdTipeKamar]    Script Date: 22/06/2022 11:17:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_IdTipeKamar]
AS
BEGIN
SELECT MAX(Right( idKamar ,3)) + 1 AS idReturn FROM tblTipeKamar
END


/****** Object:  StoredProcedure [dbo].[sp_IdPenyewa]    Script Date: 24/06/2022 08:32:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[sp_IdPenyewa]
AS
BEGIN
SELECT MAX(Right( idPenyewa ,3)) + 1 AS idReturn FROM tblPenyewa
END