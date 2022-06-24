--------------------------------------------------------------------
--KELOMPOK 10------------
--M DANISH LUTHFI
--CHRISTOPER RICHARD SANTOSO
--------------------------------------------------------------------


/****** Object:  StoredProcedure [dbo].[sp_DeleteFasilitas]    Script Date: 22/06/2022 10:50:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[sp_DeleteFasilitas]
	@idFasilitas	VARCHAR	(10)
AS
BEGIN
	DELETE FROM tblFasilitas WHERE idFasilitas = @idFasilitas
END

/****** Object:  StoredProcedure [dbo].[sp_DeleteKaryawan]    Script Date: 22/06/2022 10:51:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[sp_DeleteKaryawan]
	@idKaryawan	VARCHAR	(10)
AS
BEGIN
	DELETE FROM tbKaryawan WHERE idKaryawan = @idKaryawan
END

/****** Object:  StoredProcedure [dbo].[sp_DeleteLaundry]    Script Date: 22/06/2022 10:51:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[sp_DeleteLaundry]
	@idLaundry			VARCHAR		(10)
AS
BEGIN
	Delete From tblLaundry
	 where idLaundry = @idLaundry
END

/****** Object:  StoredProcedure [dbo].[sp_DeleteRole]    Script Date: 22/06/2022 10:52:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[sp_DeleteRole]
	@idRole			VARCHAR		(10)
AS
BEGIN
	Delete From tblRoleKaryawan
	 where idRole = @idRole
END

/****** Object:  StoredProcedure [dbo].[sp_Deletetipekamar]    Script Date: 22/06/2022 10:53:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[sp_Deletetipekamar]
	@idkamar varchar(10)
AS
BEGIN
	DELETE FROM tblTipeKamar WHERE idkamar=@idkamar
END
