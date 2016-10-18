USE [GD1C2016]

-----------------------------------------------------------
-- Borro el esquema si existe y lo vuelvo a crear
-----------------------------------------------------------

IF  EXISTS (SELECT * FROM sys.schemas WHERE name = 'LOS_INSISTENTES')
DROP SCHEMA [LOS_INSISTENTES]
GO

CREATE SCHEMA LOS_INSISTENTES AUTHORIZATION gd
GO

-----------------------------------------------------------
-- Creación de tablas
-----------------------------------------------------------

CREATE TABLE LOS_INSISTENTES.Configuraciones
(
	NombreConfig			NVARCHAR(50) NOT NULL,
	ValorConfig				NVARCHAR(50) NOT NULL,
	Descripcion				NVARCHAR(255) NULL,

	UNIQUE (NombreConfig)
)

CREATE TABLE LOS_INSISTENTES.Usuarios
(
	ID_User					NUMERIC(18,0) IDENTITY(1,1),
	Username				NVARCHAR(255)	   NOT NULL,
	Password				NVARCHAR(255)	   NOT NULL,
	Intentos_Login			TINYINT DEFAULT 0 NOT NULL, 
	Habilitado				BIT DEFAULT 1	   NOT NULL,
	Publi_Gratuitas			TINYINT DEFAULT 0 NOT NULL,
	Primera_Vez			 TINYINT DEFAULT 2 NOT NULL,
	
	UNIQUE (Username),
	PRIMARY KEY(ID_User)
)

CREATE TABLE LOS_INSISTENTES.Funcionalidades
(
	ID_Funcionalidad		NUMERIC(18,0) IDENTITY,
	Nombre					NVARCHAR(255) NOT NULL,
	Habilitado				BIT DEFAULT 1	   NOT NULL,
	
	UNIQUE (Nombre),
	PRIMARY KEY (ID_Funcionalidad)
)

CREATE TABLE LOS_INSISTENTES.Rubros 
(
	ID_Rubro				NUMERIC(18,0) IDENTITY,
	Descripcion				NVARCHAR(255) NOT NULL,
	
	UNIQUE (Descripcion),
	PRIMARY KEY (ID_Rubro)
)

CREATE TABLE LOS_INSISTENTES.VisibilidadesTabla
(
	Cod_Visibilidad			NUMERIC(18,0) IDENTITY (0,1),
	Descripcion				NVARCHAR(255) NOT NULL,
	Costo_Publicacion		NUMERIC(18,2) NULL,
	Comision_Envio			NUMERIC(18,2) NULL,
	Comision_Venta			NUMERIC(18,2) NOT NULL,
	Habilitada				BIT DEFAULT 1 NOT NULL,
	Permite_Envios			BIT DEFAULT 1 NOT NULL
	
	UNIQUE (Descripcion),
	PRIMARY KEY ( Cod_Visibilidad )
)

CREATE TABLE LOS_INSISTENTES.Estados_Publicacion
(
	Cod_EstadoPublicacion	NUMERIC(18,0) IDENTITY(0,1),
	Descripcion				NVARCHAR(255) NOT NULL,
	Orden					NUMERIC(18,0) DEFAULT 1
	
	UNIQUE (Descripcion),
	PRIMARY KEY (Cod_EstadoPublicacion)
)

CREATE TABLE LOS_INSISTENTES.Tipos_Publicacion
(
	Cod_TipoPublicacion		NUMERIC(18,0) IDENTITY(0,1),
	Descripcion				NVARCHAR(255) NOT NULL
	
	UNIQUE (Descripcion),
	PRIMARY KEY (Cod_TipoPublicacion)
)

CREATE TABLE LOS_INSISTENTES.Publicaciones
(
	Cod_Publicacion			NUMERIC(18,0) IDENTITY,
	Cod_Visibilidad			NUMERIC(18,0) NOT NULL,
	Cod_EstadoPublicacion	NUMERIC(18,0) NOT NULL,
	Cod_TipoPublicacion		NUMERIC(18,0) NOT NULL, 
	ID_Vendedor				NUMERIC(18,0) NOT NULL,
	ID_Rubro				NUMERIC(18,0) NOT NULL,
	Descripcion				NVARCHAR(255) NOT NULL,
	Stock					NUMERIC(18,0) NOT NULL,
	Fecha_Vencimiento		DATETIME NOT NULL,
	Fecha_Inicial			DATETIME NOT NULL,
	Precio					NUMERIC(18,2) NOT NULL,
	Monto_Minimo			NUMERIC(18,2) NULL,
	Permite_Envios			BIT DEFAULT 1 NOT NULL
	
	PRIMARY KEY (Cod_Publicacion),
	FOREIGN KEY (Cod_Visibilidad) REFERENCES LOS_INSISTENTES.VisibilidadesTabla(Cod_Visibilidad),
	FOREIGN KEY (Cod_EstadoPublicacion) REFERENCES LOS_INSISTENTES.Estados_Publicacion(Cod_EstadoPublicacion),
	FOREIGN KEY (Cod_TipoPublicacion) REFERENCES LOS_INSISTENTES.Tipos_Publicacion(Cod_TipoPublicacion),
	FOREIGN KEY (ID_Vendedor) REFERENCES LOS_INSISTENTES.Usuarios(ID_User),
	FOREIGN KEY (ID_Rubro) REFERENCES LOS_INSISTENTES.Rubros(ID_Rubro)
)

CREATE TABLE LOS_INSISTENTES.Facturas
(
	Nro_Factura				NUMERIC(18,0) IDENTITY,
	Forma_Pago				NVARCHAR(255) NOT NULL,
	Total_Facturacion		NUMERIC(18,2) NOT NULL,
	Factura_Fecha			DATETIME,
	
	PRIMARY KEY (Nro_Factura)
)

CREATE TABLE LOS_INSISTENTES.Item_Factura
(
	Nro_Factura				NUMERIC(18,0),
	Cod_Publicacion			NUMERIC(18,0),
	Concepto				NVARCHAR(255),
	Item_Monto				NUMERIC(18,2) NOT NULL,
	Item_Cantidad			NUMERIC(18,0) NOT NULL,
	
	FOREIGN KEY (Nro_Factura) REFERENCES LOS_INSISTENTES.Facturas(Nro_Factura),
	FOREIGN KEY (Cod_Publicacion) REFERENCES LOS_INSISTENTES.Publicaciones(Cod_Publicacion)
)


CREATE TABLE LOS_INSISTENTES.Empresas
(
	Razon_Social			NVARCHAR(255) NOT NULL,
	CUIT					NVARCHAR(50)  NOT NULL,
	ID_User					NUMERIC(18,0),
	Telefono				NVARCHAR(50) NULL, 
	Direccion				NVARCHAR(255) NOT NULL,
	Codigo_Postal			NVARCHAR(50)  NOT NULL,
	Ciudad					NVARCHAR(50)  NULL,
	Mail					NVARCHAR(50)  NOT NULL,
	Nombre_Contacto			NVARCHAR(50)  NULL,
	ID_Rubro_Principal		NUMERIC(18,0) NULL,

	PRIMARY KEY (Razon_Social, CUIT),
	FOREIGN KEY (ID_User) REFERENCES LOS_INSISTENTES.Usuarios(ID_User)
)

CREATE TABLE LOS_INSISTENTES.Clientes
(
	Tipo_Doc				NVARCHAR(50)  NOT NULL,
	Num_Doc					NUMERIC(18,0) NOT NULL,
	ID_User					NUMERIC(18,0),
	Nombre					NVARCHAR(255) NOT NULL,
	Apellido				NVARCHAR(255) NOT NULL,
	Mail					NVARCHAR(255) NOT NULL,
	Telefono				NVARCHAR(50) NULL,
	Direccion				NVARCHAR(255) NOT NULL,
	Codigo_Postal			NVARCHAR(50)  NOT NULL,
	Fecha_Nacimiento		DATETIME NOT NULL,
	Fecha_Creacion			DATETIME,
	
	PRIMARY KEY (Tipo_Doc,Num_Doc),	
	FOREIGN KEY (ID_User) REFERENCES LOS_INSISTENTES.Usuarios(ID_User)
)

CREATE TABLE LOS_INSISTENTES.Roles
(
	ID_Rol					NUMERIC(18,0) IDENTITY(0,1),
	Nombre					NVARCHAR(255) NOT NULL,
	Habilitado				BIT NOT NULL,
	
	UNIQUE (Nombre),
	PRIMARY KEY (ID_Rol)
)

CREATE TABLE LOS_INSISTENTES.Funcionalidad_Rol 
( 
	ID_Funcionalidad		NUMERIC(18,0) NOT NULL, 
	ID_Rol					NUMERIC(18,0) NOT NULL,
	
	PRIMARY KEY (ID_Funcionalidad, ID_Rol), 
	FOREIGN KEY (ID_Funcionalidad) REFERENCES LOS_INSISTENTES.Funcionalidades(ID_Funcionalidad), 
	FOREIGN KEY (ID_Rol) REFERENCES LOS_INSISTENTES.Roles(ID_Rol)
) 
	
	
CREATE TABLE LOS_INSISTENTES.Roles_Usuarios 
( 
	ID_User					NUMERIC(18,0) NOT NULL,
	ID_Rol					NUMERIC(18,0) NOT NULL,
	Habilitado				BIT DEFAULT 1	   NOT NULL,
	
	PRIMARY KEY (ID_User, ID_Rol), 
	FOREIGN KEY (ID_User) REFERENCES LOS_INSISTENTES.Usuarios(ID_User), 
	FOREIGN KEY (ID_Rol)  REFERENCES LOS_INSISTENTES.Roles(ID_Rol) 
	
)

CREATE TABLE LOS_INSISTENTES.Calificaciones
(
	Cod_Calificacion		NUMERIC(18,0)	IDENTITY,  
	Puntaje					NUMERIC(18,0)	NULL,
	Descripcion				NVARCHAR(255)	NULL,
	Fecha_Calificacion		DATETIME		NULL,
	
	PRIMARY KEY ( Cod_Calificacion )
)
GO

CREATE TABLE LOS_INSISTENTES.Compras
(
	ID_Compra				NUMERIC(18,0) IDENTITY,
	ID_Comprador			NUMERIC(18,0) NOT NULL,
	Cod_Publicacion			NUMERIC(18,0) NOT NULL,
	Cod_Calificacion		NUMERIC(18,0) NULL,
	Fecha_Operacion			DATETIME	  NOT NULL,
	Monto_Compra			NUMERIC(18,2) NOT NULL,
	Forma_Pago				NVARCHAR(255),
	Con_Envio				BIT DEFAULT 0 NOT NULL
	
	PRIMARY KEY (ID_Compra),
	FOREIGN KEY (ID_Comprador)    REFERENCES LOS_INSISTENTES.Usuarios(ID_User),
	FOREIGN KEY (Cod_Publicacion) REFERENCES LOS_INSISTENTES.Publicaciones(Cod_Publicacion),
	FOREIGN KEY (Cod_Calificacion) REFERENCES LOS_INSISTENTES.Calificaciones(Cod_Calificacion)
)
GO

CREATE TABLE LOS_INSISTENTES.Subastas
(
	ID_Subasta				NUMERIC(18,0) IDENTITY,
	ID_Comprador			NUMERIC(18,0) NOT NULL,
	Cod_Publicacion			NUMERIC(18,0) NOT NULL,
	Fecha_Oferta			DATETIME	  NOT NULL,
	Monto_Oferta			NUMERIC(18,2) NOT NULL,
	Con_Envio				BIT DEFAULT 0 NOT NULL
	
	PRIMARY KEY (ID_Subasta),
	FOREIGN KEY (Cod_Publicacion) REFERENCES LOS_INSISTENTES.Publicaciones(Cod_Publicacion),
	FOREIGN KEY (ID_Comprador)    REFERENCES LOS_INSISTENTES.Usuarios(ID_User)

)
GO

/*
-----------------------------------------------------------
-- Indices para permitir NULL insertados en migracion
-----------------------------------------------------------

CREATE UNIQUE NONCLUSTERED INDEX idx_telefono_notnull
ON LOS_INSISTENTES.Clientes(Telefono)
WHERE Telefono IS NOT NULL;

CREATE UNIQUE NONCLUSTERED INDEX idx_id_rubro_principal_notnull
ON LOS_INSISTENTES.Empresas(ID_Rubro_Principal)
WHERE ID_Rubro_Principal IS NOT NULL;
*/

-----------------------------------------------------------
-- Creación de SPs
-----------------------------------------------------------

/* FC que me devuelve el nombre del cliente o de la empresa */
CREATE FUNCTION LOS_INSISTENTES.fc_Nombre (@ID_User numeric(18,0))
RETURNS nvarchar(255)
AS
BEGIN
	DECLARE @retorno nvarchar(255)
	SELECT @retorno = Nombre + ' ' + Apellido FROM LOS_INSISTENTES.Clientes
	JOIN LOS_INSISTENTES.Usuarios ON Usuarios.ID_User = Clientes.ID_User
	WHERE Usuarios.ID_User = @ID_User

	IF @@ROWCOUNT != 1
	BEGIN
		SELECT @retorno = Razon_Social FROM LOS_INSISTENTES.Empresas
		JOIN LOS_INSISTENTES.Usuarios ON Usuarios.ID_User = Empresas.ID_User
		WHERE Usuarios.ID_User = @ID_User
	END
	-- 26/06/2016 Arreglo problema de NULL
	RETURN ISNULL(@retorno, 'Sin nombre')
END
GO

/* FC que me devuelve el máximo entre dos valores */
CREATE FUNCTION LOS_INSISTENTES.fc_MaximoEntre(@val1 int, @val2 int)
RETURNS INT
AS BEGIN
  IF @val1 > @val2
    RETURN @val1
  RETURN isnull(@val2,@val1)
END
GO

/* SP Agregar FUNCIONALIDAD al ROL */

CREATE PROCEDURE LOS_INSISTENTES.sp_AgregarFuncionalidadRol(@idRol numeric(18,0), @idFuncionalidad numeric(18,0))
AS
BEGIN
	INSERT INTO LOS_INSISTENTES.Funcionalidad_Rol VALUES (@idFuncionalidad, @idRol)
END
GO

/* SP Quitar FUNCIONALIDAD al ROL */

CREATE PROCEDURE LOS_INSISTENTES.sp_QuitarFuncionalidadRol(@rol nvarchar(255), @funcionalidad nvarchar(255)) AS
BEGIN
	DELETE FROM LOS_INSISTENTES.Funcionalidad_Rol
		WHERE 
			(SELECT ID_Rol FROM LOS_INSISTENTES.Roles WHERE Nombre = @rol)
			= LOS_INSISTENTES.Funcionalidad_Rol.ID_Rol
			AND
			(SELECT ID_Funcionalidad FROM LOS_INSISTENTES.Funcionalidades WHERE Nombre = @funcionalidad)
			= LOS_INSISTENTES.Funcionalidad_Rol.ID_Funcionalidad
END
GO

/* SP Deshabilitar FUNCIONALIDAD */

CREATE PROCEDURE LOS_INSISTENTES.sp_DeshabilitarFuncionalidad(@ID_Funcionalidad numeric(18,0)) AS
BEGIN
	UPDATE LOS_INSISTENTES.Funcionalidades SET Habilitado = 0 WHERE ID_Funcionalidad = @ID_Funcionalidad
END
GO

/* SP Habilitar FUNCIONALIDAD */

CREATE PROCEDURE LOS_INSISTENTES.sp_HabilitarFuncionalidad(@ID_Funcionalidad numeric(18,0)) AS
BEGIN
	UPDATE LOS_INSISTENTES.Funcionalidades SET Habilitado = 1 WHERE ID_Funcionalidad = @ID_Funcionalidad
END
GO

/* SP Deshabilitar ROL */

CREATE PROCEDURE LOS_INSISTENTES.sp_DeshabilitarRol(@ID_Rol numeric(18,0)) AS
BEGIN
BEGIN TRY
	UPDATE LOS_INSISTENTES.Roles SET Habilitado = 0 WHERE ID_Rol = @ID_Rol
END TRY
BEGIN CATCH
END CATCH
END
GO

CREATE PROCEDURE LOS_INSISTENTES.sp_ModificarRol
	(@ID_Rol numeric(18,0), @nombre nvarchar(255), @habilitado bit) AS
BEGIN
BEGIN TRY
		DELETE FROM LOS_INSISTENTES.Funcionalidad_Rol WHERE ID_Rol = @ID_Rol
		UPDATE LOS_INSISTENTES.Roles SET Habilitado = @habilitado, Nombre = @nombre WHERE ID_Rol = @ID_Rol
END TRY
BEGIN CATCH
END CATCH
END
GO

/* SP Habilitar ROL */

CREATE PROCEDURE LOS_INSISTENTES.sp_HabilitarRol(@ID_Rol numeric(18,0)) AS
BEGIN
BEGIN TRY
	UPDATE LOS_INSISTENTES.Roles SET Habilitado = 1 WHERE ID_Rol = @ID_Rol
END TRY
BEGIN CATCH
END CATCH
END
GO

/* SP agregar ROL a la base */

CREATE PROCEDURE LOS_INSISTENTES.sp_agregarRolNuevo(@nombreRol nvarchar(255), @retorno numeric (18,0) output)
AS BEGIN
	INSERT INTO LOS_INSISTENTES.Roles (Nombre, Habilitado) VALUES (@nombreRol, 1)
	SET @retorno = SCOPE_IDENTITY()
END
GO

/* SP Deshabilitar USUARIO */

CREATE PROCEDURE LOS_INSISTENTES.sp_DeshabilitarUsuario(@ID_User numeric(18,0)) AS
BEGIN
	UPDATE LOS_INSISTENTES.Usuarios SET Habilitado = 0 WHERE ID_User = @ID_User
END
GO

/* SP Habilitar USUARIO */

CREATE PROCEDURE LOS_INSISTENTES.sp_HabilitarUsuario(@ID_User numeric(18,0)) AS
BEGIN
	UPDATE LOS_INSISTENTES.Usuarios SET Habilitado = 1 WHERE ID_User = @ID_User
END
GO

CREATE PROCEDURE LOS_INSISTENTES.sp_ResetIntentosLogin(@ID_User numeric(18,0)) AS
BEGIN
	UPDATE LOS_INSISTENTES.Usuarios SET Intentos_Login = 0 WHERE ID_User = @ID_User
END
GO

CREATE PROCEDURE LOS_INSISTENTES.sp_SumarIntentoLogin(@ID_User numeric(18,0)) AS
BEGIN
	UPDATE LOS_INSISTENTES.Usuarios SET Intentos_Login = (Intentos_Login+1) WHERE ID_User = @ID_User
END
GO

CREATE PROCEDURE LOS_INSISTENTES.sp_CambiarPassword(@ID_User numeric(18,0), @password nvarchar(255)) AS
BEGIN
	UPDATE LOS_INSISTENTES.Usuarios SET Password = @Password, Primera_Vez = 0 WHERE ID_User = @ID_user
END
GO


/* SP agregar ROL al USUARIO */

CREATE PROCEDURE LOS_INSISTENTES.sp_AgregarRolAUsuario(@iduser numeric(18,0), @idrol numeric(18,0)) AS
BEGIN
	INSERT INTO LOS_INSISTENTES.Roles_Usuarios (ID_User,ID_Rol)
		VALUES ((SELECT ID_User FROM LOS_INSISTENTES.Usuarios WHERE ID_User = @iduser),
		(SELECT ID_Rol FROM LOS_INSISTENTES.Roles WHERE ID_Rol = @idrol))
END 
GO

/* SP quitar ROL al USUARIO */

CREATE PROCEDURE LOS_INSISTENTES.sp_QuitarRolAUsuario(@iduser numeric(18,0), @idrol numeric(18,0)) AS
BEGIN
	DELETE FROM LOS_INSISTENTES.Roles_Usuarios WHERE ID_User = @iduser AND ID_Rol = @idrol
END 
GO

CREATE PROCEDURE LOS_INSISTENTES.sp_CrearFactura
	(@formaDePago nvarchar(255), @fechaFactura datetime, @retorno numeric(18,0) output)
AS BEGIN
	INSERT INTO LOS_INSISTENTES.Facturas
		(Forma_Pago, Factura_Fecha, Total_Facturacion)
	VALUES
		(@formaDePago, @fechaFactura, 0)
		SET @retorno = SCOPE_IDENTITY()
END
GO

CREATE PROCEDURE LOS_INSISTENTES.sp_InsertarItemFactura
	(@codPublicacion numeric(18,0), @idFactura numeric(18,0), @itemCantidad numeric(18,0),
	 @concepto nvarchar(255), @itemMonto numeric(18,2))
AS BEGIN
	INSERT INTO LOS_INSISTENTES.Item_Factura
		(Cod_Publicacion, Nro_Factura, Item_Cantidad, Concepto, Item_Monto)
	VALUES
		(@codPublicacion, @idFactura, @itemCantidad, @concepto, @itemMonto)

	IF @concepto = 'Primer publicación gratuita'
		UPDATE LOS_INSISTENTES.Usuarios SET Publi_Gratuitas = 0 WHERE ID_User = (SELECT ID_Vendedor FROM Publicaciones WHERE Cod_Publicacion = @codPublicacion)
END
GO

CREATE PROCEDURE LOS_INSISTENTES.sp_AgregarCalificacionNula
	(@codCalificacion numeric(18,0) output)
AS BEGIN
		INSERT INTO LOS_INSISTENTES.Calificaciones (Puntaje, Descripcion, Fecha_Calificacion)
		VALUES (NULL, NULL, NULL)
		SET @codCalificacion = SCOPE_IDENTITY()
END
GO

CREATE PROCEDURE LOS_INSISTENTES.sp_ModificarCalificacion
	(@codCalificacion numeric(18,0), @puntaje numeric(18,0), @descripcion nvarchar(255), @fecha datetime)
AS BEGIN
		UPDATE LOS_INSISTENTES.Calificaciones
		SET Puntaje = @puntaje, Descripcion = @descripcion, Fecha_Calificacion = @fecha
		WHERE Cod_Calificacion = @codCalificacion
END
GO

CREATE PROCEDURE LOS_INSISTENTES.sp_InsertarOferta 
	(@idComprador numeric (18,0), @codPublicacion numeric (18,0), 
	 @fechaOferta datetime, @montoOferta numeric (18,2), @conEnvio bit)
AS BEGIN
		INSERT INTO LOS_INSISTENTES.Subastas
			(ID_Comprador,Cod_Publicacion, Fecha_Oferta, Monto_Oferta, Con_Envio)
		VALUES 
			(@idComprador, @codPublicacion, @fechaOferta, @montoOferta, @conEnvio)

		UPDATE LOS_INSISTENTES.Publicaciones SET Precio = @montoOferta, Monto_Minimo = @montoOferta WHERE Cod_Publicacion = @codPublicacion
END
GO

CREATE PROCEDURE LOS_INSISTENTES.sp_ComprarProducto 
	(@idComprador numeric (18,0), @codPublicacion numeric (18,0), @montoCompra numeric(18,2),
	 @fechaOferta datetime, @conEnvio bit, @retorno int output)
AS BEGIN
	INSERT INTO LOS_INSISTENTES.Compras (
		ID_Comprador, Cod_Publicacion, Cod_Calificacion, Fecha_Operacion, Monto_Compra, Forma_Pago, Con_Envio)
	VALUES (@idComprador, @codPublicacion, NULL, @fechaOferta, @montoCompra, 'Efectivo', @conEnvio)

	SELECT @retorno = f.Nro_Factura FROM LOS_INSISTENTES.Facturas f
	JOIN LOS_INSISTENTES.Item_Factura i on f.Nro_Factura = i.Nro_Factura
	WHERE Cod_Publicacion = @codPublicacion
END
GO

CREATE PROCEDURE LOS_INSISTENTES.sp_AgregarPublicacion
	(@codVisibilidad numeric(18,0), @estadoPubl numeric(18,0), @tipoPubl numeric(18,0),
	 @idVendedor numeric(18,0), @idRubro numeric(18,0), @descripcion nvarchar(255),
	 @stock numeric(18,0), @fechaVenc datetime, @fechaInic datetime, @precio numeric(18,2),
	 @montoMinimo numeric(18,2), @permiteEnvio bit, @retorno numeric (18,0) output)
AS BEGIN
		INSERT INTO LOS_INSISTENTES.Publicaciones
			(Cod_Visibilidad, Cod_EstadoPublicacion, Cod_TipoPublicacion, ID_Vendedor, ID_Rubro, Descripcion,
			 Stock, Fecha_Vencimiento, Fecha_Inicial, Precio, Permite_Envios, Monto_Minimo)
			VALUES
			(@codVisibilidad, @estadoPubl, @tipoPubl, @idVendedor, @idRubro, @descripcion, @stock,
			 @fechaVenc, @fechaInic, @precio, @permiteEnvio, @montoMinimo)

		SET @retorno = SCOPE_IDENTITY()
END
GO

CREATE PROCEDURE LOS_INSISTENTES.sp_PublicarPublicacion
	(@codPublicacion numeric(18,0))
AS BEGIN
	UPDATE LOS_INSISTENTES.Publicaciones SET Cod_EstadoPublicacion = 1 WHERE Cod_Publicacion = @codPublicacion
END
GO

CREATE PROCEDURE LOS_INSISTENTES.sp_PausarPublicacion
	(@codPublicacion numeric(18,0))
AS BEGIN
	UPDATE LOS_INSISTENTES.Publicaciones SET Cod_EstadoPublicacion = 2 WHERE Cod_Publicacion = @codPublicacion
END
GO

CREATE PROCEDURE LOS_INSISTENTES.sp_FinalizarPublicacion
	(@codPublicacion numeric(18,0))
AS BEGIN
	UPDATE LOS_INSISTENTES.Publicaciones SET Cod_EstadoPublicacion = 3 WHERE Cod_Publicacion = @codPublicacion
END
GO

CREATE PROCEDURE LOS_INSISTENTES.sp_ModificarPublicacion
	(@codPublicacion numeric(18,0), @codVisibilidad numeric(18,0), @estadoPubl numeric(18,0),
	 @tipoPubl numeric(18,0), @idRubro numeric(18,0), @descripcion nvarchar(255),
	 @stock numeric(18,0), @fechaVenc datetime, @fechaInic datetime, @precio numeric(18,2),
	 @montoMinimo numeric(18,2), @permiteEnvio bit, @retorno int output)
AS BEGIN
		UPDATE LOS_INSISTENTES.Publicaciones SET
			Cod_Visibilidad = @codVisibilidad,
			Cod_EstadoPublicacion = @estadoPubl,
			Cod_TipoPublicacion = @tipoPubl,
			ID_Rubro = @idRubro,
			Descripcion = @descripcion,
			Stock = @stock,
			Fecha_Vencimiento = @fechaVenc,
			Fecha_Inicial = @fechaInic,
			Precio = @precio,
			Permite_Envios = @permiteEnvio,
			Monto_Minimo = @montoMinimo
			WHERE Cod_Publicacion = @codPublicacion

			SET @retorno = @@ROWCOUNT
END
GO

/*
 SP Agregar CLIENTE nuevo 
   0: insertados OK el cliente y su usuario/rol asociado
  -1: el usuario ya existe
  -2: el cliente ya existe
  -3: problema con la asignación de roles
*/
CREATE PROCEDURE LOS_INSISTENTES.sp_AgregarCliente
	(@username nvarchar(255), @password nvarchar(255),
	 @tipoDoc nvarchar(50), @numDoc numeric(18,0), @nombre nvarchar(255), @apellido nvarchar(255),
	 @mail nvarchar(255), @telefono numeric(18,0), @direccion nvarchar(255), @codigoPostal nvarchar(50),
	 @fechaNac datetime, @fechaCreacion datetime, @retorno numeric(18,0) output)
AS BEGIN
	BEGIN TRANSACTION
	BEGIN TRY

		SET @retorno = -1

		DECLARE @PubliGratuitas numeric(18,0)

		SELECT @PubliGratuitas = CONVERT(numeric(18,0), ValorConfig) FROM LOS_INSISTENTES.Configuraciones WHERE NombreConfig = 'PubliGratuitas'

		INSERT INTO LOS_INSISTENTES.Usuarios(Username, Password, Intentos_Login, Habilitado, Publi_Gratuitas)
		VALUES(@username, @password, 0, 1, @PubliGratuitas)

		DECLARE @ID_User numeric (18,0) = SCOPE_IDENTITY()

		SET @retorno = -2

		INSERT INTO LOS_INSISTENTES.Clientes VALUES
		(@tipoDoc,@numDoc,@ID_User,@nombre,@apellido,@mail,@telefono,@direccion,@codigoPostal,@fechaNac,@fechaCreacion)

		SET @retorno = -3

		-- Le agrego el rol de cliente
		EXEC LOS_INSISTENTES.sp_AgregarRolAUsuario @ID_User, 1

		SET @retorno = 0

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH

END
GO

CREATE PROCEDURE LOS_INSISTENTES.sp_ModificarCliente
	(@ID_User numeric(18,0), @tipoDoc nvarchar(50), @numDoc numeric(18,0), @nombre nvarchar(255),
	 @apellido nvarchar(255), @mail nvarchar(255), @telefono numeric(18,0), @direccion nvarchar(255),
	 @codigoPostal nvarchar(50), @fechaNac datetime)
AS BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		UPDATE LOS_INSISTENTES.Clientes SET
		Tipo_Doc = @tipoDoc,
		Num_Doc = @numDoc,
		Nombre = @nombre,
		Apellido = @apellido,
		Mail = @mail,
		Telefono = @telefono,
		Direccion = @direccion,
		Codigo_Postal = @codigoPostal,
		Fecha_Nacimiento = @fechaNac
		WHERE ID_User = @ID_User
		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

/*
 SP Agregar EMPRESA nueva 
   0: insertados OK la empresa y su usuario/rol asociado
  -1: el usuario ya existe
  -2: la empresa ya existe
  -3: problema con la asignación de roles
*/
CREATE PROCEDURE LOS_INSISTENTES.sp_AgregarEmpresa
	(@username nvarchar(255), @password nvarchar(255),
	 @razonSocial nvarchar(50), @cuit nvarchar(50), @telefono numeric(18,0), @direccion nvarchar(255),
	 @ciudad nvarchar(50), @codigoPostal nvarchar(50), @mail nvarchar(255), @nombreContacto nvarchar(50),
	 @idRubro numeric(18,0), @retorno numeric(18,0) output)
AS BEGIN
	BEGIN TRANSACTION
	BEGIN TRY

		SET @retorno = -1

		DECLARE @PubliGratuitas numeric(18,0)

		SELECT @PubliGratuitas = CONVERT(numeric(18,0), ValorConfig) FROM LOS_INSISTENTES.Configuraciones WHERE NombreConfig = 'PubliGratuitas'

		INSERT INTO LOS_INSISTENTES.Usuarios(Username, Password, Intentos_Login, Habilitado, Publi_Gratuitas)
		VALUES(@username, @password, 0, 1, @PubliGratuitas)

		DECLARE @ID_User numeric (18,0) = SCOPE_IDENTITY()

		SET @retorno = -2

		INSERT INTO LOS_INSISTENTES.Empresas VALUES
		(@razonSocial,@cuit,@ID_User,@telefono,@direccion,@codigoPostal,@ciudad,@mail,@nombreContacto,@idRubro)

		SET @retorno = -3

		-- Le agrego el rol de empresa
		EXEC LOS_INSISTENTES.sp_AgregarRolAUsuario @ID_User, 2

		SET @retorno = 0

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH
END
GO

CREATE PROCEDURE LOS_INSISTENTES.sp_ModificarEmpresa
	(@ID_User numeric(18,0), @razonSocial nvarchar(50), @cuit nvarchar(50), @telefono numeric(18,0),
	 @direccion nvarchar(255), @ciudad nvarchar(50), @codigoPostal nvarchar(50), @mail nvarchar(255),
	 @nombreContacto nvarchar(50), @idRubro numeric(18,0))
AS BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		UPDATE LOS_INSISTENTES.Empresas SET
		Razon_Social = @razonSocial,
		CUIT = @cuit,
		Telefono = @telefono,
		Direccion = @direccion,
		Ciudad = @direccion,
		Codigo_Postal = @codigoPostal,
		Mail = @mail,
		Nombre_Contacto = @nombreContacto,
		ID_Rubro_Principal = @idRubro
		WHERE ID_User = @ID_User
		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

/*Procedimiento que se usa solo la primera vez, para mensaje de bienvenida*/
CREATE PROCEDURE LOS_INSISTENTES.sp_deshabilitarPrimeraVez(@habilitado numeric(18,0))
AS
BEGIN
	UPDATE LOS_INSISTENTES.Configuraciones
	SET ValorConfig=@habilitado
	WHERE NombreConfig='PrimeraVezPrograma'
END
GO

/* VW y SP para 8. Historial Cliente */
CREATE VIEW LOS_INSISTENTES.vw_ComprasYSubastas AS
SELECT t.ID_Comprador, t.Cod_Publicacion, Descripcion, Fecha_Oferta AS Fecha_Operacion, Monto_Oferta, 
		CASE
		WHEN (p.Monto_Minimo > t.Monto_Oferta) THEN 'Oferta en subasta'
		WHEN (p.Monto_Minimo = t.Monto_Oferta AND c.ID_Compra IS NOT NULL) THEN 'Subasta adjudicada'
		WHEN (p.Monto_Minimo = t.Monto_Oferta AND c.ID_Compra IS NULL) THEN 'Oferta en subasta'
		END AS Tipo
		FROM LOS_INSISTENTES.Subastas t, LOS_INSISTENTES.Publicaciones p
		LEFT JOIN LOS_INSISTENTES.Compras c on c.Cod_Publicacion = p.Cod_Publicacion
		WHERE t.Cod_Publicacion = p.Cod_Publicacion
UNION
SELECT ID_Comprador, t.Cod_Publicacion, Descripcion, Fecha_Operacion, Monto_Compra, 'Compra inmediata' AS Tipo
		FROM LOS_INSISTENTES.Compras t, LOS_INSISTENTES.Publicaciones p
		WHERE
		t.Cod_Publicacion NOT IN (
			SELECT Cod_Publicacion FROM LOS_INSISTENTES.Subastas s WHERE t.ID_Comprador = s.ID_Comprador AND s.Monto_Oferta = t.Monto_Compra
		) AND t.Cod_Publicacion = p.Cod_Publicacion
GO

CREATE PROCEDURE LOS_INSISTENTES.sp_ObtenerComprasYSubastasPorPagina(@pagina int,@ID_User numeric(18,0))
AS
	SELECT * FROM (
		SELECT ROW_NUMBER() OVER(ORDER BY Fecha_Operacion DESC) AS Fila, Cod_Publicacion, Descripcion, Fecha_Operacion, Monto_Oferta, Tipo
		FROM LOS_INSISTENTES.vw_ComprasYSubastas
		WHERE ID_Comprador = @ID_User
	) AS T
	WHERE
		Fila BETWEEN ((@pagina) + (9*(@pagina-1))) AND ((@pagina) + (9*(@pagina-1))) + 9
	ORDER BY Fecha_Operacion DESC
GO

CREATE PROCEDURE LOS_INSISTENTES.sp_ObtenerPublicacionesPorPagina(@pagina int,@ID_User numeric(18,0))
AS

	SELECT * FROM (
		SELECT ROW_NUMBER() OVER(ORDER BY e.Descripcion DESC, Cod_Publicacion DESC) AS Fila, Cod_Publicacion, e.Orden AS Orden, p.Fecha_Vencimiento AS Fecha, p.Descripcion AS Descripcion,  r.Descripcion AS Rubro, t.Descripcion As Tipo, v.Descripcion AS Visibilidad, e.Descripcion AS Estado
		FROM LOS_INSISTENTES.Publicaciones p
		JOIN LOS_INSISTENTES.Tipos_Publicacion t on t.Cod_TipoPublicacion = p.Cod_TipoPublicacion
		JOIN LOS_INSISTENTES.Visibilidades v on v.Cod_Visibilidad = p.Cod_Visibilidad
		JOIN LOS_INSISTENTES.Estados_Publicacion e on e.Cod_EstadoPublicacion = p.Cod_EstadoPublicacion
		JOIN LOS_INSISTENTES.Rubros r on r.ID_Rubro = p.ID_Rubro
		WHERE ID_Vendedor = @ID_User
	) AS T
	WHERE
		Fila BETWEEN ((@pagina) + (14*(@pagina-1))) AND ((@pagina) + (14*(@pagina-1))) + 14
	ORDER BY Orden, Fecha
GO

CREATE VIEW LOS_INSISTENTES.vw_ResumenEstrellas AS
SELECT 
	LOS_INSISTENTES.Usuarios.ID_User	AS ID_User,
	COUNT(Puntaje)						AS Cant_Estrellas,
	ISNULL(round(AVG(Puntaje), 2),0)	AS Promedio
			
	FROM LOS_INSISTENTES.Usuarios
	INNER JOIN LOS_INSISTENTES.Compras on ID_Comprador = ID_User
	INNER JOIN LOS_INSISTENTES.Calificaciones on Calificaciones.Cod_Calificacion = Compras.Cod_Calificacion
	WHERE ID_User < 50
	GROUP BY LOS_INSISTENTES.Usuarios.ID_User
GO

CREATE VIEW LOS_INSISTENTES.vw_CantComprasSinCalificar AS
SELECT
	LOS_INSISTENTES.Usuarios.ID_User		AS ID_User,
	COUNT(*)								AS CantComprasSinCalificar

	FROM LOS_INSISTENTES.Usuarios
	INNER JOIN LOS_INSISTENTES.Compras on ID_Comprador = ID_User
	INNER JOIN LOS_INSISTENTES.Calificaciones on Calificaciones.Cod_Calificacion = Compras.Cod_Calificacion
	WHERE Calificaciones.Puntaje IS NULL
	GROUP BY LOS_INSISTENTES.Usuarios.ID_User
GO

CREATE VIEW LOS_INSISTENTES.vw_UltimasCincoCalificaciones AS
	SELECT co.ID_Comprador AS ID_Comprador, p.Descripcion AS Producto, LOS_INSISTENTES.fc_Nombre(p.ID_Vendedor) AS Vendedor, 
	CONVERT(nvarchar(20), ca.Fecha_Calificacion, 103) AS Fecha, ca.Puntaje, ca.Descripcion AS Descripcion, ca.Cod_Calificacion AS Cod_Calificacion
	FROM LOS_INSISTENTES.Calificaciones ca
	JOIN LOS_INSISTENTES.Compras co on co.Cod_Calificacion = ca.Cod_Calificacion
	JOIN LOS_INSISTENTES.Publicaciones p on co.Cod_Publicacion = p.Cod_Publicacion
	WHERE Fecha_Calificacion IS NOT NULL AND Puntaje IS NOT NULL AND ca.Descripcion IS NOT NULL
GO

CREATE PROCEDURE LOS_INSISTENTES.sp_ObtenerCalificacionesPendientes (@pagina int,@ID_User numeric(18,0))
AS
	SELECT * FROM (
		SELECT ROW_NUMBER() OVER(ORDER BY Fecha_Operacion DESC) AS Fila, c.Cod_Publicacion, ca.Cod_Calificacion,
			p.Descripcion, Fecha_Operacion, Monto_Compra, t.Descripcion AS Tipo
			FROM LOS_INSISTENTES.Compras c, LOS_INSISTENTES.Publicaciones p, 
			LOS_INSISTENTES.Tipos_Publicacion t, LOS_INSISTENTES.Calificaciones ca
			WHERE
			c.Cod_Publicacion = p.Cod_Publicacion AND p.Cod_TipoPublicacion = t.Cod_TipoPublicacion
			AND c.Cod_Calificacion = ca.Cod_Calificacion AND ca.Puntaje IS NULL AND c.ID_Comprador = @ID_User
	) AS T
	WHERE
		Fila BETWEEN ((@pagina) + (9*(@pagina-1))) AND ((@pagina) + (9*(@pagina-1))) + 9
	ORDER BY Fecha_Operacion DESC
GO

/* VW y SP para 10. Facturas realizadas al vendedor */
CREATE VIEW LOS_INSISTENTES.vw_FacturasRealizadas AS
	SELECT DISTINCT
		Publicaciones.ID_Vendedor,
		Facturas.Nro_Factura,
		Facturas.Forma_Pago,
		Facturas.Total_Facturacion,
		Factura_Fecha
	FROM
		LOS_INSISTENTES.Facturas
		JOIN LOS_INSISTENTES.Item_Factura ON Item_Factura.Nro_Factura = Facturas.Nro_Factura
		JOIN LOS_INSISTENTES.Publicaciones ON Publicaciones.Cod_Publicacion = Item_Factura.Cod_Publicacion
		-- Problemas con las nuevas
		-- JOIN LOS_INSISTENTES.vw_ComprasYSubastas ON vw_ComprasYSubastas.Cod_Publicacion = Publicaciones.Cod_Publicacion
		-- Saco esto porque la factura existe igual para otros conceptos
		-- WHERE Total_Facturacion != 0
GO
/* 7. Comprar/Ofertar */
CREATE PROCEDURE LOS_INSISTENTES.sp_ObtenerCantidadPaginasPosiblesCompras (
	@ID_User numeric (18,0), @ID_Rubros nvarchar(255), @descripcion nvarchar(255))
AS BEGIN

		DECLARE @SQLQuery AS NVarchar(4000)
		DECLARE @Parametros AS NVarchar(2000)

		SET @SQLQuery = 'SELECT CEILING(COUNT(*)/15) AS Paginas
			FROM LOS_INSISTENTES.Publicaciones p
			JOIN LOS_INSISTENTES.Tipos_Publicacion t on t.Cod_TipoPublicacion = p.Cod_TipoPublicacion
			JOIN LOS_INSISTENTES.Visibilidades v on v.Cod_Visibilidad = p.Cod_Visibilidad
			JOIN LOS_INSISTENTES.Estados_Publicacion e on e.Cod_EstadoPublicacion = p.Cod_EstadoPublicacion
			JOIN LOS_INSISTENTES.Rubros r on r.ID_Rubro = p.ID_Rubro
			WHERE ID_Vendedor != @ID_User AND p.Cod_EstadoPublicacion IN (1,2) AND p.Stock > 0'
			-- 26/06/2016 Agrego Stock > 0
		 IF (@ID_Rubros IS NOT NULL)
			 SET @SQLQuery = @SQLQuery + ' AND (p.ID_Rubro IN (' + @ID_Rubros + '))'

		 IF (@descripcion IS NOT NULL)
			 SET @SQLQuery = @SQLQuery + ' AND (p.Descripcion LIKE ''%'+ @descripcion +'%'')'

		SET @Parametros =      '@ID_User nvarchar(255),
								@ID_Rubros nvarchar(255),
								@descripcion nvarchar(255)'
		Execute sp_Executesql
			@SQLQuery, @Parametros, @ID_User, @ID_Rubros, @descripcion
END
GO

CREATE PROCEDURE LOS_INSISTENTES.sp_ObtenerPosiblesCompras (
	@pagina int, @ID_User numeric (18,0), @ID_Rubros nvarchar(255), @descripcion nvarchar(255))
AS
	    DECLARE @SQLQuery AS NVarchar(4000)
		DECLARE @Parametros AS NVarchar(2000)

		SET @SQLQuery = 'SELECT * FROM (
			SELECT ROW_NUMBER() OVER(ORDER BY v.Costo_Publicacion DESC) AS Fila, Cod_Publicacion, Stock, p.Permite_Envios, Costo_Publicacion, p.Descripcion AS Descripcion,  r.Descripcion AS Rubro, t.Descripcion As Tipo, e.Descripcion AS Estado, p.Precio AS montoCompra
			FROM LOS_INSISTENTES.Publicaciones p
			JOIN LOS_INSISTENTES.Tipos_Publicacion t on t.Cod_TipoPublicacion = p.Cod_TipoPublicacion
			JOIN LOS_INSISTENTES.Visibilidades v on v.Cod_Visibilidad = p.Cod_Visibilidad
			JOIN LOS_INSISTENTES.Estados_Publicacion e on e.Cod_EstadoPublicacion = p.Cod_EstadoPublicacion
			JOIN LOS_INSISTENTES.Rubros r on r.ID_Rubro = p.ID_Rubro
			WHERE ID_Vendedor != @ID_User AND p.Cod_EstadoPublicacion IN (1,2) AND p.Stock > 0'
			-- 26/06/2016 Agrego Stock > 0
		 IF (@ID_Rubros IS NOT NULL)
			 SET @SQLQuery = @SQLQuery + ' AND (p.ID_Rubro IN (' + @ID_Rubros + '))'

		 IF (@descripcion IS NOT NULL)
			 SET @SQLQuery = @SQLQuery + ' AND (p.Descripcion LIKE ''%'+ @descripcion +'%'')'

		SET @SQLQuery = @SQLQuery + ') 
				AS T WHERE Fila BETWEEN ((@pagina) + (14*(@pagina-1))) AND ((@pagina) + (14*(@pagina-1))) + 14
				ORDER BY Costo_Publicacion DESC'

		SET @Parametros =      '@pagina int,
								@ID_User nvarchar(255),
								@ID_Rubros nvarchar(255),
								@descripcion nvarchar(255)'
		Execute sp_Executesql
			@SQLQuery, @Parametros, @pagina, @ID_User, @ID_Rubros, @descripcion
GO

-----------------VISTAS LISTADO ESTADISTICO TOP 5-----------------------------

--------------------------------------------------------------------------------
-- Vendedores con mayor cantidad de productos no vendidos
--------------------------------------------------------------------------------

CREATE VIEW LOS_INSISTENTES.vw_ProductosNoVendidos AS
	SELECT	LOS_INSISTENTES.fc_nombre(ID_Vendedor)		AS Vendedor,
			Publicaciones.Descripcion					AS Publicacion,
			VisibilidadesTabla.Cod_Visibilidad				AS Cod_Visibilidad,
			Publicaciones.Stock							AS Stock,
			MONTH(Publicaciones.Fecha_Inicial)			AS Mes,
			YEAR(Publicaciones.Fecha_Inicial)			AS Año

			FROM LOS_INSISTENTES.Publicaciones
			JOIN LOS_INSISTENTES.VisibilidadesTabla ON Publicaciones.Cod_Visibilidad = VisibilidadesTabla.Cod_Visibilidad
GO
--------------------------------------------------------------------------------
-- Clientes con mayor cantidad de productos comprados
--------------------------------------------------------------------------------

CREATE VIEW  LOS_INSISTENTES.vw_CantidadProductosComprados AS
	SELECT  LOS_INSISTENTES.fc_nombre(ID_Comprador)		AS Comprador,
			Publicaciones.ID_Rubro						AS ID_Rubro,
			COUNT(*)									AS Cantidad, 
			MONTH(Fecha_Operacion)						AS Mes,									
			YEAR(Fecha_Operacion)						AS Año

		FROM	LOS_INSISTENTES.Compras
		JOIN LOS_INSISTENTES.Publicaciones on Compras.Cod_Publicacion = Publicaciones.Cod_Publicacion
		GROUP BY ID_Comprador, ID_Rubro, MONTH(Fecha_Operacion), YEAR(Fecha_Operacion)
GO

--------------------------------------------------------------------------------
-- Vendedores con mayor cantidad de facturas
--------------------------------------------------------------------------------

CREATE VIEW  LOS_INSISTENTES.vw_CantidadFacturasPorMes AS
		SELECT  LOS_INSISTENTES.fc_nombre(ID_Vendedor)		AS Vendedor,
				COUNT(*)									AS Cantidad, 
				MONTH(Facturas.Factura_Fecha)				AS Mes,									
				YEAR(Facturas.Factura_Fecha)				AS Año

		FROM	LOS_INSISTENTES.Facturas, 
				(SELECT DISTINCT Nro_Factura, Cod_Publicacion FROM LOS_INSISTENTES.Item_Factura) Item_Factura,
				LOS_INSISTENTES.Publicaciones
		WHERE 
				Publicaciones.Cod_Publicacion = Item_Factura.Cod_Publicacion
				AND Facturas.Total_Facturacion != 0
				AND Item_Factura.Nro_Factura = Facturas.Nro_Factura
		GROUP BY ID_Vendedor, MONTH(Facturas.Factura_Fecha), YEAR(Facturas.Factura_Fecha)
GO

--------------------------------------------------------------------------------
-- Vendedores con mayor monto facturado
--------------------------------------------------------------------------------

CREATE VIEW  LOS_INSISTENTES.vw_FacturacionTotalPorMes AS
	SELECT  LOS_INSISTENTES.fc_nombre(ID_Vendedor)		AS Vendedor,
			SUM(Facturas.Total_Facturacion)				AS Total, 
			MONTH(Facturas.Factura_Fecha)				AS Mes,									
			YEAR(Facturas.Factura_Fecha)				AS Año

		FROM	LOS_INSISTENTES.Facturas, 
				(SELECT DISTINCT Nro_Factura, Cod_Publicacion FROM LOS_INSISTENTES.Item_Factura) Item_Factura,
				LOS_INSISTENTES.Publicaciones
		WHERE 
				Publicaciones.Cod_Publicacion = Item_Factura.Cod_Publicacion
				AND Facturas.Total_Facturacion != 0
				AND Item_Factura.Nro_Factura = Facturas.Nro_Factura
		GROUP BY ID_Vendedor, MONTH(Facturas.Factura_Fecha), YEAR(Facturas.Factura_Fecha)
GO

/*
VER ESTA VISTA
CREATE VIEW LOS_INSISTENTES.vw_DetalleFacturasRealizadas AS
	SELECT DISTINCT
		Publicaciones.ID_Vendedor,
		Item_Monto,
		Item_Cantidad,
		Concepto,
		Facturas.Nro_Factura,
		Facturas.Forma_Pago,
		Facturas.Total_Facturacion,
		Factura_Fecha
	FROM
		LOS_INSISTENTES.Facturas
		JOIN LOS_INSISTENTES.Item_Factura ON Item_Factura.Nro_Factura = Facturas.Nro_Factura
		JOIN LOS_INSISTENTES.Publicaciones ON Publicaciones.Cod_Publicacion = Item_Factura.Cod_Publicacion
		JOIN LOS_INSISTENTES.vw_ComprasYSubastas ON vw_ComprasYSubastas.Cod_Publicacion = Publicaciones.Cod_Publicacion
		WHERE Total_Facturacion != 0
GO
*/
CREATE PROCEDURE LOS_INSISTENTES.sp_FacturasRealizadasPorPagina (
	@pagina int, @ID_Vendedor numeric(18,0), @fechaDesde datetime, @fechaHasta datetime,
	@importeDesde numeric(18,2), @importeHasta numeric(18,2), @concepto nvarchar(255))
AS
	    DECLARE @SQLQuery AS NVarchar(4000)
		DECLARE @Parametros AS NVarchar(2000)

		SET @SQLQuery = 'SELECT * FROM (
					SELECT ROW_NUMBER() OVER(ORDER BY Factura_Fecha DESC) AS Fila, Nro_Factura, Forma_Pago, CONVERT(DECIMAL(10,2),Total_Facturacion) AS Total_Facturacion, Factura_Fecha
					FROM LOS_INSISTENTES.vw_FacturasRealizadas
					WHERE ID_Vendedor = @ID_Vendedor'

		 IF (@fechaDesde IS NOT NULL AND @fechaHasta IS NOT NULL)
			 SET @SQLQuery = @SQLQuery + ' AND (Factura_Fecha BETWEEN @fechaDesde AND @fechaHasta)'

		IF (@importeDesde IS NOT NULL AND @importeHasta IS NOT NULL)
			SET @SQLQuery = @SQLQuery + ' AND (Total_Facturacion BETWEEN @importeDesde AND @importeHasta)'

		IF (@concepto IS NOT NULL)
			SET @SQLQuery = @SQLQuery + ' AND Nro_Factura IN (SELECT Nro_Factura FROM LOS_INSISTENTES.Item_Factura WHERE Concepto LIKE ''%'+ @concepto +'%'')'

		SET @SQLQuery = @SQLQuery + ') 
				AS T WHERE Fila BETWEEN ((@pagina) + (9*(@pagina-1))) AND ((@pagina) + (9*(@pagina-1))) + 9
				ORDER BY Factura_Fecha DESC'

		SET @Parametros =      '@pagina int,
								@ID_Vendedor numeric(18,0),
								@fechaDesde datetime,
								@fechaHasta datetime,
								@importeDesde numeric(18,2),
								@importeHasta numeric(18,2),
								@concepto nvarchar(255)'

		Execute sp_Executesql
			@SQLQuery, @Parametros, @pagina, @ID_Vendedor, @fechaDesde, @fechaHasta, @importeDesde, @importeHasta, @concepto
GO

CREATE PROCEDURE LOS_INSISTENTES.sp_ObtenerClientesPorPagina (
	@pagina int, @nombre nvarchar(255), @apellido nvarchar(255), @email nvarchar(255),
	@tipoDoc nvarchar(50), @numeroDoc numeric(18,0))
AS
	    DECLARE @SQLQuery AS NVarchar(4000)
		DECLARE @Parametros AS NVarchar(2000)

		SET @SQLQuery = 'SELECT * FROM (
						SELECT ROW_NUMBER() OVER(ORDER BY u.ID_User) AS Fila, u.ID_User, Nombre, Apellido, Tipo_Doc, Num_Doc, Mail
						FROM LOS_INSISTENTES.Clientes c
						JOIN LOS_INSISTENTES.Usuarios u ON u.ID_User = c.ID_User WHERE Habilitado = 1'

		 IF (@nombre IS NOT NULL)
			 SET @SQLQuery = @SQLQuery + ' AND (Nombre LIKE ''%'+ @nombre +'%'')'

		 IF (@apellido IS NOT NULL)
			 SET @SQLQuery = @SQLQuery + ' AND (Apellido LIKE ''%'+ @apellido +'%'')'

		 IF (@email IS NOT NULL)
			 SET @SQLQuery = @SQLQuery + ' AND (Mail LIKE ''%'+ @email +'%'')'

		 IF (@tipoDoc IS NOT NULL AND @numeroDoc IS NOT NULL)
			 SET @SQLQuery = @SQLQuery + ' AND (Tipo_Doc = @tipoDoc AND CONVERT(nvarchar(255),Num_Doc) LIKE ''%'+  CONVERT(nvarchar(255),@numeroDoc) +'%'')'

		SET @SQLQuery = @SQLQuery + ') 
				AS T WHERE Fila BETWEEN ((@pagina) + (9*(@pagina-1))) AND ((@pagina) + (9*(@pagina-1))) + 9
				ORDER BY ID_User'

		SET @Parametros =      '@pagina int,
								@nombre nvarchar(255),
								@apellido nvarchar(255),
								@email nvarchar(255),
								@tipoDoc nvarchar(50),
								@numeroDoc numeric(18,0)'
		Execute sp_Executesql
			@SQLQuery, @Parametros, @pagina, @nombre, @apellido, @email, @tipoDoc, @numeroDoc
GO

CREATE PROCEDURE LOS_INSISTENTES.sp_ObtenerEmpresasPorPagina (
	@pagina int, @razonSocial nvarchar(255), @cuit nvarchar(50), @email nvarchar(255))
AS
	    DECLARE @SQLQuery AS NVarchar(4000)
		DECLARE @Parametros AS NVarchar(2000)

		SET @SQLQuery = 'SELECT * FROM (
						SELECT ROW_NUMBER() OVER(ORDER BY u.ID_User) AS Fila, u.ID_User, Razon_Social, CUIT, Mail
						FROM LOS_INSISTENTES.Empresas e
						JOIN LOS_INSISTENTES.Usuarios u ON u.ID_User = e.ID_User WHERE Habilitado = 1'

		 IF (@razonSocial IS NOT NULL)
			 SET @SQLQuery = @SQLQuery + ' AND (Razon_Social LIKE ''%'+ @razonSocial +'%'')'

		 IF (@cuit IS NOT NULL)
			 SET @SQLQuery = @SQLQuery + ' AND (CUIT LIKE ''%'+ @cuit +'%'')'

		 IF (@email IS NOT NULL)
			 SET @SQLQuery = @SQLQuery + ' AND (Mail LIKE ''%'+ @email +'%'')'

		SET @SQLQuery = @SQLQuery + ') 
				AS T WHERE Fila BETWEEN ((@pagina) + (9*(@pagina-1))) AND ((@pagina) + (9*(@pagina-1))) + 9
				ORDER BY ID_User'

		SET @Parametros =      '@pagina int,
								@razonSocial nvarchar(255),
								@cuit nvarchar(50),
								@email nvarchar(255)'

		Execute sp_Executesql
			@SQLQuery, @Parametros, @pagina, @razonSocial, @cuit, @email
GO

/* SP Finalizar Subastas */
/* VER BIEN ESTE QUERY */
CREATE PROCEDURE LOS_INSISTENTES.sp_FinalizarSubastas
	(@fechaSistema datetime)
AS BEGIN

	INSERT INTO LOS_INSISTENTES.Compras
	SELECT s.ID_Comprador, p.Cod_Publicacion, NULL, @fechaSistema, s.Monto_Oferta, c.Forma_Pago, p.Permite_Envios -- Le pongo que saque el envío 09/07/2016
	FROM LOS_INSISTENTES.Publicaciones p, 
		(SELECT Cod_Publicacion, ID_Comprador, MAX(Monto_Oferta) AS Monto_Oferta FROM LOS_INSISTENTES.Subastas s WHERE s.Cod_Publicacion = Cod_Publicacion GROUP BY Cod_Publicacion, ID_Comprador) s,
		(SELECT DISTINCT Forma_Pago FROM LOS_INSISTENTES.Item_Factura i, LOS_INSISTENTES.Facturas f
		WHERE f.Nro_Factura = i.Nro_Factura AND i.Cod_Publicacion = Cod_Publicacion) c
	WHERE s.Cod_Publicacion = p.Cod_Publicacion
	AND p.Cod_TipoPublicacion = 0  -- Subasta
	AND Cod_EstadoPublicacion = 1  -- Publicada
	-- 27/06/2016 Si no supera el monto mínimo no agrega la compra, sólo finaliza la subasta
	AND s.Monto_Oferta >= p.Monto_Minimo
	AND Fecha_Vencimiento < @fechaSistema

	UPDATE LOS_INSISTENTES.Publicaciones SET Cod_EstadoPublicacion = 3 -- Finalizada
	WHERE Cod_TipoPublicacion = 0  -- Subasta
	AND Cod_EstadoPublicacion = 1  -- Publicada
	AND Fecha_Vencimiento < @FechaSistema
END
GO

/* SEGUIR POR ACA */

/* SP Agregar VISIBILIDAD */

CREATE PROCEDURE LOS_INSISTENTES.sp_AgregarVisibilidad
	(@descripcion nvarchar(255), @costoPublicacion numeric(18,2), @comisionEnvio numeric(18,2),
	 @comisionVenta numeric(18,2), @habilitada bit, @permiteEnvio bit, @retorno numeric(18,0) output)
AS BEGIN
	INSERT INTO LOS_INSISTENTES.VisibilidadesTabla
		(Descripcion, Costo_Publicacion, Comision_Envio, Comision_Venta, Habilitada, Permite_Envios)
	VALUES
		(@descripcion, @costoPublicacion, @comisionEnvio, @comisionVenta, @habilitada, @permiteEnvio)

	SET @retorno = SCOPE_IDENTITY();
END
GO

/* SP Editar VISIBILIDAD */

CREATE PROCEDURE LOS_INSISTENTES.sp_ModificarVisibilidad
	(@codVisibilidad numeric(18,0), @descripcion nvarchar(255), @costoPublicacion numeric(18,2),
	 @comisionEnvio numeric(18,2), @comisionVenta numeric(18,2), @habilitada bit, @permiteEnvio bit)
AS BEGIN
	UPDATE LOS_INSISTENTES.VisibilidadesTabla 
	SET Descripcion = @descripcion, Comision_Envio = @comisionEnvio,
	Costo_Publicacion = @costoPublicacion, Comision_Venta = @comisionVenta,
	Habilitada = @habilitada, Permite_Envios = @permiteEnvio
	WHERE Cod_Visibilidad = @codVisibilidad
END
GO

/* SP Eliminar VISIBILIDAD */

CREATE PROCEDURE LOS_INSISTENTES.sp_EliminarVisibilidad
	(@codVisibilidad numeric(18,0))
AS BEGIN
	DECLARE @cantidadPublicaciones numeric(18,0)
	SELECT @cantidadPublicaciones = COUNT(*) FROM LOS_INSISTENTES.Publicaciones WHERE Cod_Visibilidad = @codVisibilidad
	AND Cod_EstadoPublicacion != 3 -- 09/07/2016 obtengo la cantidad de publicaciones NO finalizadas
	IF @cantidadPublicaciones = 0
	BEGIN
		UPDATE LOS_INSISTENTES.VisibilidadesTabla SET Habilitada = 0 WHERE Cod_Visibilidad = @codVisibilidad
	END
	ELSE
	BEGIN
		DECLARE @errorVisibilidad varchar(255)
		SET @errorVisibilidad = 'La visibilidad tiene' + CONVERT(varchar(25), @cantidadPublicaciones) + ' publicaciones asignadas, no se puede dar de baja'
		RAISERROR (@errorVisibilidad,16,1)
	END
END
GO

-----------------------------------------------------------
-- Carga de datos iniciales
-----------------------------------------------------------

PRINT ''
PRINT 'Cargando datos iniciales manualmente ...'
PRINT ''

PRINT ''
PRINT 'Llenamos la tabla de configuraciones'
PRINT ''

/* CONFIGURACIONES */
INSERT INTO LOS_INSISTENTES.Configuraciones VALUES ('FechaSistema','30/07/2016','Fecha configurada para usar en la app, igual la lee del app.config.');
INSERT INTO LOS_INSISTENTES.Configuraciones VALUES ('PubliGratuitas','1', 'Cantidad de publicaciones gratuitas para usuario nuevo.');
INSERT INTO LOS_INSISTENTES.Configuraciones VALUES ('IntentosLogin','3', 'Cantidade de intentos fallidos antes de bloquear el usuario.');
INSERT INTO LOS_INSISTENTES.Configuraciones VALUES ('LimiteCalificaciones','3', 'Cantidade de calificaciones para que el sistema no te deje comprar.');
INSERT INTO LOS_INSISTENTES.Configuraciones VALUES ('EsquemaBD','LOS_INSISTENTES', 'Esquema de la base de datos.');
INSERT INTO LOS_INSISTENTES.Configuraciones VALUES ('CantidadTop','5', 'Cantidad de registros para el Top de listados.');
INSERT INTO LOS_INSISTENTES.Configuraciones VALUES ('PrimeraVezPrograma','1', 'Usado para el mensaje de bienvenida.');

/* FUNCIONALIDADES */
SET IDENTITY_INSERT LOS_INSISTENTES.Funcionalidades ON
INSERT INTO LOS_INSISTENTES.Funcionalidades (ID_Funcionalidad, Nombre) VALUES (1,'Administrar Usuarios');
INSERT INTO LOS_INSISTENTES.Funcionalidades (ID_Funcionalidad, Nombre) VALUES (2,'Administrar Roles');
INSERT INTO LOS_INSISTENTES.Funcionalidades (ID_Funcionalidad, Nombre, Habilitado) VALUES (3,'Administrar Rubros', 0);
INSERT INTO LOS_INSISTENTES.Funcionalidades (ID_Funcionalidad, Nombre, Habilitado) VALUES (4,'Administrar Visibilidades', 1);
INSERT INTO LOS_INSISTENTES.Funcionalidades (ID_Funcionalidad, Nombre) VALUES (5,'Administrar Publicaciones');
INSERT INTO LOS_INSISTENTES.Funcionalidades (ID_Funcionalidad, Nombre) VALUES (6,'Comprar / Ofertar');
INSERT INTO LOS_INSISTENTES.Funcionalidades (ID_Funcionalidad, Nombre) VALUES (7,'Calificar');
INSERT INTO LOS_INSISTENTES.Funcionalidades (ID_Funcionalidad, Nombre) VALUES (8,'Historial Cliente');
INSERT INTO LOS_INSISTENTES.Funcionalidades (ID_Funcionalidad, Nombre) VALUES (9,'Consultar Facturas');
INSERT INTO LOS_INSISTENTES.Funcionalidades (ID_Funcionalidad, Nombre) VALUES (10,'Listado Estadístico');
INSERT INTO LOS_INSISTENTES.Funcionalidades (ID_Funcionalidad, Nombre, Habilitado) VALUES (11,'Cambiar Contraseña', 1);
SET IDENTITY_INSERT LOS_INSISTENTES.Funcionalidades OFF

/* ROLES */
SET IDENTITY_INSERT LOS_INSISTENTES.Roles ON
INSERT INTO LOS_INSISTENTES.Roles (ID_Rol, Nombre, Habilitado) VALUES (0, 'Administrador', 1);
INSERT INTO LOS_INSISTENTES.Roles (ID_Rol, Nombre, Habilitado) VALUES (1, 'Cliente', 1);
INSERT INTO LOS_INSISTENTES.Roles (ID_Rol, Nombre, Habilitado) VALUES (2, 'Empresa', 1);
SET IDENTITY_INSERT LOS_INSISTENTES.Roles OFF

PRINT ''
PRINT 'Asignamos las funcionalidades a los roles ...'
PRINT ''

/* Asignación de Funcionalidades */

/* ADMIN */ 
EXEC LOS_INSISTENTES.sp_AgregarFuncionalidadRol
	@idRol = 0, @idFuncionalidad = 2;
EXEC LOS_INSISTENTES.sp_AgregarFuncionalidadRol
	@idRol = 0, @idFuncionalidad = 1;
EXEC LOS_INSISTENTES.sp_AgregarFuncionalidadRol
	@idRol = 0, @idFuncionalidad = 3;
EXEC LOS_INSISTENTES.sp_AgregarFuncionalidadRol
	@idRol = 0, @idFuncionalidad = 4;
EXEC LOS_INSISTENTES.sp_AgregarFuncionalidadRol
	@idRol = 0, @idFuncionalidad = 10;
EXEC LOS_INSISTENTES.sp_AgregarFuncionalidadRol
	@idRol = 0, @idFuncionalidad = 11;
		
/* Cliente */

EXEC LOS_INSISTENTES.sp_AgregarFuncionalidadRol
	@idRol = 1, @idFuncionalidad = 6;	
EXEC LOS_INSISTENTES.sp_AgregarFuncionalidadRol
	@idRol = 1, @idFuncionalidad = 7;
EXEC LOS_INSISTENTES.sp_AgregarFuncionalidadRol
	@idRol = 1, @idFuncionalidad = 8;
EXEC LOS_INSISTENTES.sp_AgregarFuncionalidadRol
	@idRol = 1, @idFuncionalidad = 11;

	
/* Empresas */

EXEC LOS_INSISTENTES.sp_AgregarFuncionalidadRol
	@idRol = 2, @idFuncionalidad = 5;		
EXEC LOS_INSISTENTES.sp_AgregarFuncionalidadRol
	@idRol = 2, @idFuncionalidad = 9;
EXEC LOS_INSISTENTES.sp_AgregarFuncionalidadRol
	@idRol = 2, @idFuncionalidad = 11;
		

/* Generamos el usuario admin con la password indicada en el enunciado */

SET IDENTITY_INSERT LOS_INSISTENTES.Usuarios ON
INSERT INTO LOS_INSISTENTES.Usuarios(ID_User,Username,Password,Intentos_Login,Habilitado,Publi_Gratuitas, Primera_Vez) 
	VALUES (0,'admin','E6B87050BFCB8143FCB8DB0170A4DC9ED00D904DDD3E2A4AD1B1E8DC0FDC9BE7',0,1,0,0);
SET IDENTITY_INSERT LOS_INSISTENTES.Usuarios OFF

EXEC LOS_INSISTENTES.sp_AgregarRolAUsuario
	@iduser = 0, @idrol = 0;
/* Generamos los estados de publicación */
SET IDENTITY_INSERT LOS_INSISTENTES.Estados_Publicacion ON
INSERT INTO LOS_INSISTENTES.Estados_Publicacion (Cod_EstadoPublicacion, Descripcion) VALUES (0,'Borrador');
INSERT INTO LOS_INSISTENTES.Estados_Publicacion (Cod_EstadoPublicacion, Descripcion) VALUES (1,'Publicada');
INSERT INTO LOS_INSISTENTES.Estados_Publicacion (Cod_EstadoPublicacion, Descripcion) VALUES (2,'Pausada');
INSERT INTO LOS_INSISTENTES.Estados_Publicacion (Cod_EstadoPublicacion, Descripcion) VALUES (3,'Finalizada');
SET IDENTITY_INSERT LOS_INSISTENTES.Estados_Publicacion OFF

GO

/* Generamos los tipos de publicación */

SET IDENTITY_INSERT LOS_INSISTENTES.Tipos_Publicacion ON
INSERT INTO LOS_INSISTENTES.Tipos_Publicacion (Cod_TipoPublicacion, Descripcion) VALUES(0,'Subasta');
INSERT INTO LOS_INSISTENTES.Tipos_Publicacion (Cod_TipoPublicacion, Descripcion) VALUES(1,'Compra Inmediata');
SET IDENTITY_INSERT LOS_INSISTENTES.Tipos_Publicacion OFF

GO

-----------------------------------------------------------
-- Comienza migración de datos
-----------------------------------------------------------

PRINT ''
PRINT 'Migramos la tabla Visibilidades';
PRINT ''
GO

INSERT INTO LOS_INSISTENTES.VisibilidadesTabla(Descripcion, Costo_Publicacion, Comision_Venta, Comision_Envio, Habilitada) 

	SELECT  DISTINCT 
					Publicacion_Visibilidad_Desc,
					Publicacion_Visibilidad_Precio,
					Publicacion_Visibilidad_Porcentaje,
					Publicacion_Visibilidad_Porcentaje/2,
					1
					
				
	FROM gd_esquema.Maestra
	WHERE Publicacion_Visibilidad_Cod IS NOT NULL
	ORDER BY Publicacion_Visibilidad_Precio DESC
GO

UPDATE LOS_INSISTENTES.VisibilidadesTabla SET Permite_Envios = 0 WHERE Cod_Visibilidad = 4 -- Dejo solo gratis 09/07/2016

CREATE TABLE LOS_INSISTENTES.Usuarios_temporales
(
	iduser NUMERIC(18,0) IDENTITY(1,1),
	username NVARCHAR(255) NOT NULL,
	pass NVARCHAR(255) NOT NULL,
	rol int
	PRIMARY KEY (iduser)
	
)
GO

INSERT INTO  LOS_INSISTENTES.Usuarios_temporales 
	SELECT DISTINCT	
	
		--CONVERT(nvarchar(255), Publ_Cli_Dni)									AS username,
		--'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'		AS pass,
		REPLACE(LOWER(Publ_Cli_Apeliido+Publ_Cli_Nombre),' ','')				AS username,
		CONVERT(nvarchar(255), Publ_Cli_Dni)									AS pass,
		1																		AS rol
		
	FROM gd_esquema.Maestra
	WHERE Publ_Cli_Dni IS NOT NULL
	
	UNION 
	
	SELECT DISTINCT 
	
		--Publ_Empresa_CUIT														AS username,
		--'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'		AS pass,
		'razonsocialnro'+ SUBSTRING(Publ_Empresa_Razon_Social,17,2)				AS username,
		CONVERT(nvarchar(255), Publ_Empresa_Cuit)								AS pass,
		2																		AS rol
		
	FROM gd_esquema.Maestra
	WHERE Publ_Empresa_Cuit IS NOT NULL
GO	
	
PRINT ''
PRINT 'Migramos la tabla Usuarios'
PRINT ''

SET IDENTITY_INSERT LOS_INSISTENTES.Usuarios ON

INSERT INTO LOS_INSISTENTES.Usuarios(ID_User,Username,Password,Publi_Gratuitas)
	SELECT iduser,username,pass,0
	FROM LOS_INSISTENTES.Usuarios_temporales
	
SET IDENTITY_INSERT LOS_INSISTENTES.Usuarios OFF

GO

CREATE VIEW LOS_INSISTENTES.Visibilidades
AS
	SELECT * FROM LOS_INSISTENTES.VisibilidadesTabla WHERE Habilitada = 1
GO

CREATE VIEW LOS_INSISTENTES.vw_Temporal_Calificaciones
	AS SELECT 
			LOS_INSISTENTES.Usuarios.ID_User			AS iduser,
			AVG(Calificacion_Cant_Estrellas)		AS promedio
			
	FROM gd_esquema.Maestra, LOS_INSISTENTES.Usuarios
	WHERE Calificacion_Codigo IS NOT NULL
		AND (LOS_INSISTENTES.Usuarios.Password = CONVERT(nvarchar(255), gd_esquema.Maestra.Publ_Cli_Dni)
		OR LOS_INSISTENTES.Usuarios.Password = gd_esquema.Maestra.Publ_Empresa_Cuit)
	
	GROUP BY LOS_INSISTENTES.Usuarios.ID_User
GO

PRINT ''
PRINT 'Migramos la tabla Roles_Usuarios'
PRINT ''
GO

INSERT INTO LOS_INSISTENTES.Roles_Usuarios (ID_User,ID_Rol)

	SELECT LOS_INSISTENTES.Usuarios_temporales.iduser,
		   CASE WHEN LOS_INSISTENTES.Usuarios_temporales.rol = 0 -- Admin
				THEN (0)
				WHEN LOS_INSISTENTES.Usuarios_temporales.rol = 1 -- Cliente
				THEN (1)
				WHEN LOS_INSISTENTES.Usuarios_temporales.rol = 2 -- Empresa
				THEN (2)
		   END
	FROM LOS_INSISTENTES.Usuarios_temporales
	
PRINT ''
PRINT 'Migramos la tabla Rubros'
PRINT ''

INSERT INTO LOS_INSISTENTES.Rubros(Descripcion)
	SELECT DISTINCT gd_esquema.Maestra.Publicacion_Rubro_Descripcion
		FROM gd_esquema.Maestra
			WHERE gd_esquema.Maestra.Publicacion_Cod IS NOT NULL
			
PRINT ''
PRINT 'Migramos la tabla Clientes'
PRINT ''

INSERT INTO LOS_INSISTENTES.Clientes (ID_User,
								  Tipo_Doc,
								  Num_Doc,
								  Nombre,
								  Apellido,
								  Mail,
								  Direccion,
								  Codigo_Postal,
								  Fecha_Nacimiento,
								  Fecha_Creacion)

	SELECT DISTINCT	LOS_INSISTENTES.Usuarios_temporales.iduser,
					'DU',
					gd_esquema.Maestra.Publ_Cli_Dni,		
					gd_esquema.Maestra.Publ_Cli_Nombre,	
					gd_esquema.Maestra.Publ_Cli_Apeliido,  
					gd_esquema.Maestra.Publ_Cli_Mail,
					gd_esquema.Maestra.Publ_Cli_Dom_Calle 
									  + ' ' + CONVERT(nvarchar(255),gd_esquema.Maestra.Publ_Cli_Nro_Calle)
									  + ' ' + CONVERT(nvarchar(255),gd_esquema.Maestra.Publ_Cli_Piso)
									  + ' ' + CONVERT(nvarchar(255),gd_esquema.Maestra.Publ_Cli_Depto),
					gd_esquema.Maestra.Publ_Cli_Cod_Postal,
					gd_esquema.Maestra.Publ_Cli_Fecha_Nac,
					NULL
			
	FROM LOS_INSISTENTES.Usuarios_temporales, gd_esquema.Maestra
	--WHERE Publ_Cli_Dni IS NOT NULL AND (LOS_INSISTENTES.Usuarios_temporales.username = CONVERT(nvarchar(255), gd_esquema.Maestra.Publ_Cli_Dni))
	WHERE Publ_Cli_Dni IS NOT NULL AND (LOS_INSISTENTES.Usuarios_temporales.username = REPLACE(LOWER(gd_esquema.Maestra.Publ_Cli_Apeliido+gd_esquema.Maestra.Publ_Cli_Nombre),' ',''))

PRINT ''
PRINT 'Migramos la tabla Empresas'
PRINT ''

-- Permito que ignore el duplicate key por el tema de rubro
ALTER TABLE LOS_INSISTENTES.Empresas REBUILD WITH (IGNORE_DUP_KEY = ON)

INSERT INTO LOS_INSISTENTES.Empresas (ID_User,
					Razon_Social,
					CUIT,
					Direccion,
					Codigo_Postal,
					Mail,
					ID_Rubro_Principal)

	SELECT	LOS_INSISTENTES.Usuarios_temporales.iduser,
					gd_esquema.Maestra.Publ_Empresa_Razon_Social,
					gd_esquema.Maestra.Publ_Empresa_Cuit,
					gd_esquema.Maestra.Publ_Empresa_Dom_Calle 
					+ ' ' + CONVERT(nvarchar(255),gd_esquema.Maestra.Publ_Empresa_Nro_Calle)
					+ ' ' + CONVERT(nvarchar(255),gd_esquema.Maestra.Publ_Empresa_Piso)
					+ ' ' + CONVERT(nvarchar(255),gd_esquema.Maestra.Publ_Empresa_Depto),
					gd_esquema.Maestra.Publ_Empresa_Cod_Postal,
					gd_esquema.Maestra.Publ_Empresa_Mail,
					LOS_INSISTENTES.Rubros.ID_Rubro
			
	FROM LOS_INSISTENTES.Usuarios_temporales,gd_esquema.Maestra, LOS_INSISTENTES.Rubros
	-- WHERE Publ_Empresa_Cuit  IS NOT NULL AND (LOS_INSISTENTES.Usuarios_temporales.username = Publ_Empresa_CUIT)
	WHERE Publ_Empresa_Cuit  IS NOT NULL AND (LOS_INSISTENTES.Usuarios_temporales.username = 'razonsocialnro'+ SUBSTRING(Publ_Empresa_Razon_Social,17,2))
	AND LOS_INSISTENTES.Rubros.Descripcion = gd_esquema.Maestra.Publicacion_Rubro_Descripcion
	ORDER BY LOS_INSISTENTES.Usuarios_temporales.iduser, RAND()

-- Vuelvo a habilitar el duplicate key
ALTER TABLE LOS_INSISTENTES.Empresas REBUILD WITH (IGNORE_DUP_KEY = OFF)

PRINT ''
PRINT 'Migramos la tabla Publicaciones'
PRINT ''
GO
		
CREATE VIEW LOS_INSISTENTES.vw_Temporal_Publicaciones AS SELECT DISTINCT
		LOS_INSISTENTES.Usuarios.ID_User AS ID_User, 
		Publicacion_Cod, 
		Publicacion_Visibilidad_Cod - 10002 AS Cod_Visibilidad,
		Publicacion_Descripcion,
		Publicacion_Stock,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		Publicacion_Precio, 
		3 AS Publicacion_Estado, --Publicacion_estado(Todas estan publicadas => 1)
		CASE Publicacion_Tipo WHEN 'Subasta' THEN 0
							 WHEN 'Compra Inmediata' THEN 1
		END AS Publicacion_Tipo, 
		LOS_INSISTENTES.Rubros.ID_Rubro AS ID_Rubro
					
	FROM	gd_esquema.Maestra, LOS_INSISTENTES.Usuarios, LOS_INSISTENTES.Rubros
	WHERE	LOS_INSISTENTES.Rubros.Descripcion = gd_esquema.Maestra.Publicacion_Rubro_Descripcion
	AND Publ_Cli_Dni IS NOT NULL
	AND LOS_INSISTENTES.Usuarios.Password = CONVERT(NVARCHAR(255), gd_esquema.Maestra.Publ_Cli_Dni)
	
	UNION
	
	SELECT DISTINCT
		LOS_INSISTENTES.Usuarios.ID_User AS ID_User, 
		Publicacion_Cod, 
		Publicacion_Visibilidad_Cod - 10002 AS Cod_Visibilidad,
		Publicacion_Descripcion,
		Publicacion_Stock,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		Publicacion_Precio, 
		3 AS Publicacion_Estado, --Publicacion_estado(Todas estan publicadas => 1)
		CASE Publicacion_Tipo WHEN 'Subasta' THEN 0
							 WHEN 'Compra Inmediata' THEN 1
		END AS Publicacion_Tipo, 
		LOS_INSISTENTES.Rubros.ID_Rubro AS ID_Rubro
					
	FROM	gd_esquema.Maestra, LOS_INSISTENTES.Usuarios, LOS_INSISTENTES.Rubros
	WHERE	LOS_INSISTENTES.Rubros.Descripcion = gd_esquema.Maestra.Publicacion_Rubro_Descripcion 
	AND Publ_Empresa_Cuit IS NOT NULL 
	AND LOS_INSISTENTES.Usuarios.Password = gd_esquema.Maestra.Publ_Empresa_Cuit
GO

SET IDENTITY_INSERT LOS_INSISTENTES.Publicaciones ON


INSERT INTO LOS_INSISTENTES.Publicaciones(Cod_Publicacion,
										Cod_Visibilidad,
										ID_Vendedor,
										Descripcion,
										Stock,
										Fecha_Inicial,
										Fecha_Vencimiento,
										Precio,
										Cod_EstadoPublicacion, 
										Cod_TipoPublicacion,
										ID_Rubro)
										
	SELECT Publicacion_Cod, Cod_Visibilidad, ID_User, Publicacion_Descripcion, Publicacion_Stock, Publicacion_Fecha, Publicacion_Fecha_Venc,
			Publicacion_Precio, Publicacion_Estado, Publicacion_Tipo, ID_Rubro
									
	FROM	LOS_INSISTENTES.vw_Temporal_Publicaciones

	
SET IDENTITY_INSERT LOS_INSISTENTES.Publicaciones OFF

PRINT ''
PRINT 'Migramos la tabla Facturas'
PRINT ''
GO

SET IDENTITY_INSERT LOS_INSISTENTES.Facturas ON

INSERT INTO LOS_INSISTENTES.Facturas(Nro_Factura, Forma_Pago, Total_Facturacion, Factura_Fecha)
	SELECT DISTINCT Factura_Nro, 
					Forma_Pago_Desc, 
					Factura_Total,
					Factura_Fecha
				
	FROM gd_esquema.Maestra
		WHERE gd_esquema.Maestra.Factura_Nro IS NOT NULL
	

SET IDENTITY_INSERT LOS_INSISTENTES.Facturas OFF
GO
	
PRINT ''
PRINT 'Migramos la tabla Item_Factura'
PRINT ''
GO

INSERT INTO LOS_INSISTENTES.Item_Factura(Cod_Publicacion, Nro_Factura, Item_Monto, Item_Cantidad, Concepto)
	SELECT Publicacion_Cod, Factura_Nro, 
						Item_Factura_Monto,
						Item_Factura_Cantidad,
						CASE FLOOR(Item_Factura_Monto)
							WHEN 0 THEN 'Publicación gratuita'
							WHEN Publicacion_Visibilidad_Precio THEN 'Costo de publicación '+Publicacion_Visibilidad_Desc
							WHEN FLOOR(Publicacion_Precio*Item_Factura_Cantidad*Publicacion_Visibilidad_Porcentaje) THEN 
								(SELECT TOP 1 'Venta a ' + Cli_Nombre + ' ' + Cli_Apeliido + ' el ' + convert(varchar(25), Compra_Fecha, 103) 
								FROM gd_esquema.Maestra m WHERE
								m.Publicacion_Cod = s.Publicacion_Cod
								AND m.Compra_Cantidad = s.Item_Factura_Cantidad
								AND s.Calificacion_Cant_Estrellas IS NULL)
						END AS Concepto
		FROM gd_esquema.Maestra s
			WHERE s.Factura_Nro IS NOT NULL
	ORDER BY 1, 2
GO

UPDATE LOS_INSISTENTES.Item_Factura SET Concepto = 'Costo de envío' WHERE Concepto IS NULL

PRINT ''
PRINT 'Migramos la tabla Calificaciones'
PRINT ''
GO

SET IDENTITY_INSERT LOS_INSISTENTES.Calificaciones ON

INSERT INTO LOS_INSISTENTES.Calificaciones (Cod_Calificacion, Puntaje,Descripcion, Fecha_Calificacion)
	SELECT 
			Calificacion_Codigo,
			Calificacion_Cant_Estrellas,
			Calificacion_Descripcion,
			Compra_Fecha
	FROM gd_esquema.Maestra m
	WHERE Calificacion_Codigo IS NOT NULL
	
SET IDENTITY_INSERT LOS_INSISTENTES.Calificaciones OFF
GO

UPDATE LOS_INSISTENTES.Calificaciones SET Puntaje = 1 WHERE Puntaje = 6
UPDATE LOS_INSISTENTES.Calificaciones SET Puntaje = 2 WHERE Puntaje = 7
UPDATE LOS_INSISTENTES.Calificaciones SET Puntaje = 3 WHERE Puntaje = 8
UPDATE LOS_INSISTENTES.Calificaciones SET Puntaje = 4 WHERE Puntaje = 9
UPDATE LOS_INSISTENTES.Calificaciones SET Puntaje = 5 WHERE Puntaje = 10

PRINT ''
PRINT 'Migramos la tabla Compras'
PRINT ''
GO

INSERT INTO LOS_INSISTENTES.Compras

	SELECT DISTINCT 		LOS_INSISTENTES.Usuarios.ID_User,			
					Publicacion_Cod,
					Calificacion_Codigo,						
					Compra_Fecha,							
					Publicacion_Precio,
					Forma_Pago_Desc, 0										
					
	FROM gd_esquema.Maestra, LOS_INSISTENTES.Usuarios, LOS_INSISTENTES.Publicaciones
	
	WHERE gd_esquema.Maestra.Calificacion_Codigo IS NOT NULL
	AND gd_esquema.Maestra.Compra_Fecha IS NOT NULL
	AND gd_esquema.Maestra.Publicacion_Tipo = 'Compra Inmediata'
	AND (Publ_Cli_Dni IS NOT NULL OR Publ_Empresa_Cuit IS NOT NULL)
	AND	gd_esquema.Maestra.Publicacion_Cod = LOS_INSISTENTES.Publicaciones.Cod_Publicacion 
	AND LOS_INSISTENTES.Usuarios.Password = convert(nvarchar(255),Cli_Dni)
	
GO

CREATE VIEW LOS_INSISTENTES.vw_Temporal_Subastas AS

	SELECT DISTINCT 		LOS_INSISTENTES.Usuarios.ID_User			AS ofertador,
					Publicacion_Cod							AS codpublic,
					0/*Oferta*/								AS tipo,
					Calificacion_Codigo						AS codcalific,
					Oferta_Fecha							AS fechaOferta,
					Oferta_Monto							AS monto,
					CASE 
					WHEN 
					gd_esquema.Maestra.Compra_Fecha IS NULL
					THEN 0
					WHEN gd_esquema.Maestra.Compra_Fecha IS NOT NULL
					THEN 1
					END									AS ganoSubasta
					
	FROM gd_esquema.Maestra, LOS_INSISTENTES.Usuarios, LOS_INSISTENTES.Publicaciones
	
	WHERE gd_esquema.Maestra.Calificacion_Codigo IS NULL
	AND LOS_INSISTENTES.Publicaciones.Cod_TipoPublicacion = 0
	AND (Publ_Cli_Dni IS NOT NULL OR Publ_Empresa_Cuit IS NOT NULL)
	AND	gd_esquema.Maestra.Publicacion_Cod = LOS_INSISTENTES.Publicaciones.Cod_Publicacion
	AND LOS_INSISTENTES.Usuarios.Password = convert(nvarchar(255),Cli_Dni)
	
GO	

PRINT ''
PRINT 'Migramos la tabla Subastas'
PRINT ''
GO

INSERT INTO LOS_INSISTENTES.Subastas(ID_Comprador, Cod_Publicacion, Fecha_Oferta, Monto_Oferta, Con_Envio)
	SELECT ofertador, codpublic, fechaOferta, monto, 0
		 FROM LOS_INSISTENTES.vw_Temporal_Subastas
		WHERE ganoSubasta = 0

GO

INSERT INTO LOS_INSISTENTES.Compras(ID_Comprador, Cod_Publicacion, Cod_Calificacion, Fecha_Operacion, Monto_Compra, Forma_Pago)
	 
	SELECT S1.ofertador, S1.codpublic, Calificacion_Codigo, S1.fechaOferta, MAX(s1.monto), 1
		FROM LOS_INSISTENTES.vw_Temporal_Subastas S1 
		JOIN LOS_INSISTENTES.vw_Temporal_Subastas S2 ON S1.codpublic = S2.codpublic --Mismo codigo de publicacion
		JOIN gd_esquema.Maestra ON S1.codpublic = gd_esquema.Maestra.Publicacion_Cod
		
			WHERE S1.ofertador = S2.ofertador --Mismo Ofertador
			AND S1.ganoSubasta = 0 AND S2.ganoSubasta = 1 --Que ese ofertador haya ganado
			AND gd_esquema.Maestra.Calificacion_Codigo IS NOT NULL --Para la calificacion
		GROUP BY S1.ofertador, S1.codpublic, s1.tipo, s1.fechaOferta, Calificacion_Codigo

-----------------------------------------------------------
-- Eliminación de vistas y tablas para la migración
-----------------------------------------------------------

DROP TABLE LOS_INSISTENTES.Usuarios_temporales
GO
DROP VIEW LOS_INSISTENTES.vw_Temporal_Publicaciones
GO
DROP VIEW LOS_INSISTENTES.vw_Temporal_Subastas
GO
DROP VIEW LOS_INSISTENTES.vw_Temporal_Calificaciones
GO

-----------------------------------------------------------
-- Creación de TRIGGERS
-----------------------------------------------------------

/* OJO NO DESCOMENTAR: Este trigger no permitiría cambiar nada en publicaciones finalizadas
CREATE TRIGGER LOS_INSISTENTES.tr_PublicacionFinalizada ON LOS_INSISTENTES.Publicaciones INSTEAD OF UPDATE
AS BEGIN
	BEGIN TRANSACTION
		DECLARE @estadoFinalizado numeric(18,0), @estadoPublicacion numeric(18,0)
		set @estadoFinalizado = 3
		SELECT @estadoPublicacion = Cod_EstadoPublicacion FROM deleted
		IF @estadoPublicacion = 3
			ROLLBACK
		COMMIT TRAN
END
GO
 */

CREATE TRIGGER LOS_INSISTENTES.tr_InsertaItemFactura ON LOS_INSISTENTES.Item_Factura AFTER INSERT
AS BEGIN
	UPDATE LOS_INSISTENTES.Facturas SET Total_Facturacion = 
	(SELECT SUM(Item_Monto*Item_Cantidad) FROM LOS_INSISTENTES.Item_Factura i WHERE Nro_Factura IN (SELECT Nro_Factura FROM inserted) AND i.Nro_Factura = Nro_Factura)
	WHERE Nro_Factura IN (SELECT Nro_Factura FROM inserted)
END
GO

/* Trigger para baja lógica de ROLES */
CREATE TRIGGER LOS_INSISTENTES.tr_ModificacionRol ON LOS_INSISTENTES.Roles AFTER UPDATE
AS BEGIN
	DECLARE @habilitado BIT
	SELECT TOP 1 @habilitado = Habilitado FROM inserted
	
	UPDATE LOS_INSISTENTES.Roles_Usuarios SET Habilitado = @habilitado WHERE ID_Rol IN (SELECT ID_Rol FROM inserted)
	COMMIT;
END
GO

/* Trigger para que al modificar la publicación se genere la factura si Stock = 0 o Estado = Activa */

CREATE TRIGGER LOS_INSISTENTES.tr_ModificaPublicacion ON LOS_INSISTENTES.Publicaciones AFTER UPDATE
AS BEGIN
	DECLARE @estadoActiva numeric(18,0)
	set @estadoActiva = 1

	-- Si el nuevo stock es 0, finalizo la publicación
	IF UPDATE(Stock)
	BEGIN
		UPDATE LOS_INSISTENTES.Publicaciones
		SET Cod_EstadoPublicacion = 3 WHERE Cod_Publicacion IN (SELECT Cod_Publicacion FROM inserted
		WHERE Stock = 0)-- 26/06/2016 Cod_TipoPublicacion = 1 AND Stock = 0)
	END

	IF UPDATE(Cod_EstadoPublicacion)
	BEGIN
	DECLARE @codPublicacion numeric(18,0), @visibilidad nvarchar(255), @montoPublicacion numeric(18,2),
			@fechaInicial datetime,	@nroFactura numeric(18,0), @idVendedor numeric(18,0)

	-- Tengo que generar una factura para cada publicación activa, uso un cursor
	-- 26/06/2016 Que no tenga una factura ya asociada
	DECLARE cursorFinalizadas CURSOR FAST_FORWARD FOR
		SELECT i.ID_Vendedor, i.Cod_Publicacion, 'Costo de publicación ' + v.Descripcion AS Visibilidad,
				v.Costo_Publicacion AS Monto, i.Fecha_Inicial
		FROM INSERTED i, deleted d, LOS_INSISTENTES.Visibilidades v 
		WHERE i.Cod_Visibilidad = v.Cod_Visibilidad AND
		i.Cod_EstadoPublicacion = @estadoActiva AND d.Cod_Publicacion = i.Cod_Publicacion
		AND d.Cod_EstadoPublicacion != 1 AND d.Cod_Publicacion NOT IN (
		SELECT DISTINCT Cod_Publicacion FROM LOS_INSISTENTES.Item_Factura)

	OPEN cursorFinalizadas 
	FETCH NEXT FROM cursorFinalizadas INTO @idVendedor, @codPublicacion, @visibilidad,
	@montoPublicacion, @fechaInicial

	-- Me fijo si es la primer publicación

	DECLARE @publiGratuitas bit

	SELECT @publiGratuitas = Publi_Gratuitas FROM LOS_INSISTENTES.Usuarios WHERE ID_User = @idVendedor

	IF @publiGratuitas > 0
	BEGIN
		SET @montoPublicacion = 0
		SET @visibilidad = 'Primer publicación gratuita'
	END
	
	WHILE @@FETCH_STATUS = 0 
	BEGIN 
		-- Creo una nueva factura para la publicación activa
		EXEC LOS_INSISTENTES.sp_CrearFactura 'Efectivo',@fechaInicial,@nroFactura output
		-- Agrego a Item_Factura los Items de las publicaciones que fueron activadas
		EXEC LOS_INSISTENTES.sp_InsertarItemFactura @codPublicacion, @nroFactura, 1,
		@visibilidad, @montoPublicacion
		FETCH NEXT FROM cursorFinalizadas INTO @idVendedor, @codPublicacion, @visibilidad, @montoPublicacion, @fechaInicial
	END
	CLOSE cursorFinalizadas
	DEALLOCATE cursorFinalizadas
	END
END
GO

/* Trigger para que al insertar una publicación activa genere la factura */

CREATE TRIGGER LOS_INSISTENTES.trInsertaPublicacion ON LOS_INSISTENTES.Publicaciones AFTER INSERT
AS BEGIN
	DECLARE @estadoActiva numeric(18,0)
	set @estadoActiva = 1

	DECLARE @codPublicacion numeric(18,0), @visibilidad nvarchar(255), @montoPublicacion numeric(18,2),
			@fechaInicial datetime,	@nroFactura numeric(18,0), @idVendedor numeric(18,0)

	SELECT @idVendedor = i.ID_Vendedor, @codPublicacion = i.Cod_Publicacion, @visibilidad = 'Costo de publicación ' + v.Descripcion,
			@montoPublicacion = v.Costo_Publicacion, @fechaInicial = i.Fecha_Inicial
	FROM INSERTED i, LOS_INSISTENTES.Visibilidades v
	WHERE i.Cod_Visibilidad = v.Cod_Visibilidad AND i.Cod_EstadoPublicacion = @estadoActiva AND Cod_Publicacion NOT IN
	(SELECT DISTINCT Cod_Publicacion FROM LOS_INSISTENTES.Item_Factura)

	IF @@ROWCOUNT > 0
	BEGIN

		-- Me fijo si es la primer publicación

		DECLARE @publiGratuitas bit

		SELECT @publiGratuitas = Publi_Gratuitas FROM LOS_INSISTENTES.Usuarios WHERE ID_User = @idVendedor

		IF @publiGratuitas > 0
		BEGIN
			SET @montoPublicacion = 0
			SET @visibilidad = 'Primer publicación gratuita'
		END

		-- Creo una nueva factura para la publicación activa
		EXEC LOS_INSISTENTES.sp_CrearFactura 'Efectivo',@fechaInicial,@nroFactura output
		-- Agrego a Item_Factura los Items de las publicaciones que fueron finalizadas
		EXEC LOS_INSISTENTES.sp_InsertarItemFactura @codPublicacion, @nroFactura, 1,
		@visibilidad, @montoPublicacion
	END
END
GO

/* Trigger para que al insertar una compra:
	- agregue item de comisión + de envío si aplica
	- agregue en tabla Calificaciones una nula
	- actualice Stock
*/
CREATE TRIGGER LOS_INSISTENTES.tr_InsertaCompra ON LOS_INSISTENTES.Compras INSTEAD OF INSERT
AS BEGIN
	-- Soluciono problema con el finalizar subastas
	DECLARE @cantidadAInsertar numeric(18,0)
	DECLARE @codCalificacion numeric(18,0)

	SELECT @cantidadAInsertar = COUNT(*) FROM inserted

	IF @cantidadAInsertar > 0
	BEGIN
		EXEC LOS_INSISTENTES.sp_AgregarCalificacionNula @codCalificacion output
	END
	
	DECLARE @codPublicacion numeric(18,0), @montoCompra numeric(18,2), @idComprador numeric(18,0),
			@fechaOperacion datetime, @conEnvio bit
			
	SELECT  @codPublicacion = Cod_Publicacion, @idComprador = ID_Comprador, @fechaOperacion = Fecha_Operacion,
			@montoCompra = Monto_Compra, @conEnvio = Con_Envio	FROM inserted

	-- Inserto la compra

	INSERT INTO LOS_INSISTENTES.Compras 
		(ID_Comprador, Cod_Publicacion, Cod_Calificacion, Fecha_Operacion, Monto_Compra, Forma_Pago)
	SELECT 
		ID_Comprador, Cod_Publicacion, @codCalificacion, Fecha_Operacion, Monto_Compra, Forma_Pago
	FROM INSERTED

	-- Genero el Item_Factura asociado a la compra

	INSERT INTO LOS_INSISTENTES.Item_Factura 
		SELECT DISTINCT i.Nro_Factura, p.Cod_Publicacion, 
		'Comisión venta (' + CONVERT(VARCHAR(25), Comision_Venta) + '%) a ' + LOS_INSISTENTES.fc_Nombre(@idComprador) + ' el ' + convert(varchar(25), @fechaOperacion, 103), 
		-- CONVERT(numeric(18,2),(Comision_Venta*@montoCompra)), CEILING(@montoCompra/Precio) FROM LOS_INSISTENTES.Visibilidades v,
		CONVERT(numeric(18,2),(Comision_Venta*@montoCompra)/CEILING(@montoCompra/Precio)), 1 FROM LOS_INSISTENTES.Visibilidades v,
		LOS_INSISTENTES.Facturas f, LOS_INSISTENTES.Publicaciones p, LOS_INSISTENTES.Item_Factura i
		WHERE p.Cod_Visibilidad = v.Cod_Visibilidad AND i.Cod_Publicacion = p.Cod_Publicacion
		AND f.Nro_Factura = i.Nro_Factura
		AND p.Cod_Publicacion = @codPublicacion

	-- Si eligió envíos agrego el concepto del envío

	IF @conEnvio = 1
	BEGIN
		INSERT INTO LOS_INSISTENTES.Item_Factura 
		SELECT DISTINCT i.Nro_Factura, p.Cod_Publicacion, 
		'Comisión envío (' + CONVERT(VARCHAR(25), Comision_Envio) + '%) a ' + LOS_INSISTENTES.fc_Nombre(@idComprador) + ' el ' + convert(varchar(25), @fechaOperacion, 103), 
		-- CONVERT(numeric(18,2),(Comision_Envio*@montoCompra)), CEILING(@montoCompra/Precio) FROM LOS_INSISTENTES.Visibilidades v,
		CONVERT(numeric(18,2),(Comision_Envio*@montoCompra)/CEILING(@montoCompra/Precio)), 1 FROM LOS_INSISTENTES.Visibilidades v,
		LOS_INSISTENTES.Facturas f, LOS_INSISTENTES.Publicaciones p, LOS_INSISTENTES.Item_Factura i
		WHERE p.Cod_Visibilidad = v.Cod_Visibilidad AND i.Cod_Publicacion = p.Cod_Publicacion
		AND f.Nro_Factura = i.Nro_Factura
		AND p.Cod_Publicacion = @codPublicacion
	END

	-- Si es compra inmediata le saco la cantidad comprada de Stock
	-- 26/06/2016 Arreglo problema de stock
	UPDATE LOS_INSISTENTES.Publicaciones SET Stock = LOS_INSISTENTES.fc_MaximoEntre(Stock - CEILING(@montoCompra/Precio), 0)
	WHERE Cod_Publicacion = @codPublicacion AND Cod_TipoPublicacion = 1

	-- Si es subasta vendí todo, no hay más stock
	-- 27/06/2016 - En realidad no toco el stock, hasta que se finalice la subasta
	-- UPDATE LOS_INSISTENTES.Publicaciones SET Stock = 0
	-- WHERE Cod_Publicacion = @codPublicacion AND Cod_TipoPublicacion = 0
END
GO

-- Agrego usuarios para test
PRINT ''
PRINT 'Creamos los usuarios para pruebas'
PRINT ''

EXEC LOS_INSISTENTES.sp_AgregarEmpresa 'unaempresa',
		'E6B87050BFCB8143FCB8DB0170A4DC9ED00D904DDD3E2A4AD1B1E8DC0FDC9BE7',
		'Empresa de prueba', '27-12345678-9',47777777,'Av Medrano 950','Capital Federal',1407,
		'losinsistentes@gmail.com','Los Insistentes', 1, NULL

EXEC LOS_INSISTENTES.sp_AgregarCliente 'uncliente',
		'E6B87050BFCB8143FCB8DB0170A4DC9ED00D904DDD3E2A4AD1B1E8DC0FDC9BE7','DU',32453413,
		'Prueba','Cliente','losinsistentes@gmail.com',47777777,'Av Medrano 950','Capital Federal',
		1407,NULL,NULL

EXEC LOS_INSISTENTES.sp_AgregarCliente 'muchosRoles',
		'E6B87050BFCB8143FCB8DB0170A4DC9ED00D904DDD3E2A4AD1B1E8DC0FDC9BE7','DU',1212123,
		'Muchos','Roles','losinsistentes@gmail.com',47777777,'Av Medrano 950','Capital Federal',
		1407,NULL,NULL

INSERT INTO LOS_INSISTENTES.Roles_Usuarios SELECT ID_user, 0, 1 FROM LOS_INSISTENTES.Usuarios WHERE Username = 'muchosRoles'
INSERT INTO LOS_INSISTENTES.Roles_Usuarios SELECT ID_user, 2, 1 FROM LOS_INSISTENTES.Usuarios WHERE Username = 'muchosRoles'

UPDATE LOS_INSISTENTES.Usuarios SET Primera_Vez = 0 WHERE Username IN ('unaempresa','uncliente', 'muchosroles')

UPDATE LOS_INSISTENTES.Estados_Publicacion SET Descripcion = 'Activa' WHERE Descripcion = 'Publicada'

UPDATE LOS_INSISTENTES.Estados_Publicacion SET Orden = '1' WHERE Descripcion = 'Activa'
UPDATE LOS_INSISTENTES.Estados_Publicacion SET Orden = '2' WHERE Descripcion = 'Pausada'
UPDATE LOS_INSISTENTES.Estados_Publicacion SET Orden = '3' WHERE Descripcion = 'Borrador'
UPDATE LOS_INSISTENTES.Estados_Publicacion SET Orden = '4' WHERE Descripcion = 'Finalizada'

-----------------------------FIN SCRIPT INICIAL---------------------------------
