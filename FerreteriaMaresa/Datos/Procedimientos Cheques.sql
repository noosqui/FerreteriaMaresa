Use Ferreteria_Maresa
GO

--Mostrar Bancos
Create procedure [dbo].[SP_Pago_Cheque]
As
SELECT        dbo.TipoPago.id_tipo_pago, dbo.TipoPago.descripcion, dbo.Cheques.numero_cuenta, dbo.Cheques.fecha, dbo.Cheques.id_cliente, dbo.Cheques.ruta_bancaria, dbo.Cheques.numero_cheque, dbo.Cheques.monto, 
                         dbo.Cheques.id_banco
FROM            dbo.TipoPago INNER JOIN
                         dbo.Cheques ON dbo.TipoPago.id_tipo_pago = dbo.Cheques.id_tipo_pago