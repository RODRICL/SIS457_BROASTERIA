# SIS457_BROASTERIA
POLLOS HANDA
En "Pollos Handa", nuestra misión es ofrecerte una experiencia gastronómica única, 
especializada en los más deliciosos y crujientes pollos broaster, hamburguesas, entre otros. 
Nos destacamos por combinar técnicas tradicionales con el toque especial de nuestra casa, 
logrando un sabor inigualable.

Cada pieza de pollo que preparamos pasa por un riguroso proceso que garantiza calidad, 
frescura y ese dorado perfecto que caracteriza nuestra cocina. Usamos solo los mejores 
ingredientes, para asegurarnos de que cada bocado sea un verdadero placer.

Además, estamos comprometidos con brindar un servicio de primera. Nuestro equipo trabaja
con dedicación para que cada visita sea memorable, ofreciéndote no solo la mejor comida, 
sino también la mejor atención.

####################### BASE DE DATOS ####################

Empleado(id, cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, celular, cargo)

Proveedor (id, documento, razonSocial, email, telefono) 

Cliente (id, documento, nombreCompleto, email, telefono)

Usuario (id, idEmpleado, usuario, clave)

Compra (id, idUsuario, idProveedor, tipoDocumento, numeroDocumento, montoTotal)

Categoria (id, descripcion)

Producto (id, idCategoria, codigo, nombre, descripcion, stock, precioVenta)

DetalleCompra (id, idCompra, idProducto, precioCompra, precioVenta, cantidad, total)

Venta (id, idUsuario, tipoDocumento, numeroDocumento, documentoCliente, nombreCliente, montoPago, montoCambio, montoTotal) 

DetalleVenta (id, idVenta, idProducto, precioVenta, cantidad, subTotal)

HistorialCompra (id, idProducto, precioCompra, precioVenta, cantidad)

HistorialVenta (id, idProducto, precioVenta, cantidad)