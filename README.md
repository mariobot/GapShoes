# GapShoes
Prueba tecnica para GAP, Tiendas y Articulos modo administrativo web y web api. 

En la empresa "Super Zapatos" ocupan realizar una aplicación web para llevar el control de inventario del calzado disponible en su zapatería. Dada esta necesidad, los expertos de tecnología de la empresa consideraron que la mejor opción sería hacer una aplicación ASP.Net utilizando MVC. El cliente desea que las paginas se ajusten al dispositivo que la está mostrando (Mobil, Tablet, PC). Esta se encargara de mostrar la información y un backend enviara la información a la base de datos, mediante servicios web. Además esta aplicación debería de permitir a los administradores de la empresa poder agregar la información en la base de datos.
Dada la necesidad anteriormente planteada, se consultó a un experto de base de datos y él recomendó tener una base de datos compleja para lograr el proyecto. Sin embargo, como el presupuesto del cliente era limitado, se concluyó que la mejor opción era tener únicamente el mantenimiento y los servicios esenciales de la aplicación, lo que implicaba únicamente tener dos tablas básicas, cuyas descripciones son:

table articles
id
name
description
price
total_in_shelf
total_in_vault
store_id	

table stores
id
name
address


Por otro lado, se consideró que para hacer los mantenimientos bastaban los formularios autogenerados por .Net con solo una modificación para poder elegir la tienda del artículo. Estos formularios no tienen que tener ningún tipo de autenticación para limitar el acceso al formulario. Eso sí, el cliente solicitó que quería que la parte administrativa tuviera un diseño gráfico sencillo pero agradable (nada muy complejo, con un encabezado, un pie de página y un fondo sencillo basta). Añadido a lo anterior y dadas las necesidades de la aplicación, es necesario realizar al menos 3 servicios, cuyos URL y respuestas están descritos en la documentación del API adjunta a esta prueba.
Para cerrar, para esta prueba se requerirá como entregables:
- El proyecto con las migraciones, los modelos, vistas y controladores de la aplicación.
- Generar los servicios acorde con la documentación del API adjunta.
- Todas las pantallas tendrán un diseño gráfico sencillo pero agradable.
