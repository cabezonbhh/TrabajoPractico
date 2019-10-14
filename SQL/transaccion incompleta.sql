


insert into StockUnidades(idFabricante,idSerie,idGeneracion,nombre,precioCompra,añoModelo,kilometraje,potencia,descripcion)
values (2,5,32,'M5',100000,2009,0,500,'Unidad obtenida de un excedente de stock, proviene de Munich, Alemania. Nunca se utilizo, se mantuvo almacenado en los depositos');

insert into Service(codUnidad,fechaService) values(@@IDENTITY,GETDATE()); 

insert into DetalleService(codService,codUnidad,idtrabajo,precios)
values()
