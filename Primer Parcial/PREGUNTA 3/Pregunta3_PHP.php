<title>PHP-Pregunta 3</title>
<h1>Esto es PHP</h1>
<h2>Ingresa los siguientes datos: </h2>
<form method="GET" action="http://localhost:5396/WebForm1.aspx">
	Nombre: <input type="text" name="name"/><br/><br/>
	Apellido: <input type="text" name="last_name"/><br/><br/>
	<input type="submit" name="Enviar"/>
	<br/> <br/> <br/>
	<input type="hidden" name="php_time">
</form>
<script type="text/javascript">
	var d = new Date().toLocaleDateString().concat(" ", new Date().getHours(), ":", new Date().getMinutes(), ":", new Date().getSeconds());
	document.write("Tiempo PHP: "+d);
	document.forms[0].elements[3].value=d;
</script>