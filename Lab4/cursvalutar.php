
<!doctype html>
<html>
<head>
 
 <meta charset="utf-8" />
 <title>Doina_Blog</title>
 <link href="style1.css" type="text/css" rel="stylesheet">
 
</head><!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
 <head>
  
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
     <title>Doina_Blog</title>
     <link href="style.css" type="text/css" rel="stylesheet">

 <div>

     <ul class="menu1">
 
<li><a href="1111.html">Home</a></li>
    <li><a href="text2.html">IT</a></li>
    <li><a href="cursvalutar.php">Curs Valutar</a></li>
        
</ul>
</div>
 
 </head>
 <body>
 
 <img id="f" alt="" src="image1.jpg"/>
     <h2 id="header1" align="center"><em> Curs Valutar!!!</em></h2>
     <div id="sidebarLL">
     <section id="posts">
	 
 <img id="d" alt="" src="media_1417419768610217001.png" width="240" height="200" />
 <img id="m" alt="" src="Curs-valutar-25-august-2014.jpg" width="340" height="100" />
 <img id="z" alt="" src="unnamed.png" width="240" height="200" />
</section></div>
<div id="doina111">
<div id="sidebarO">

  <p id="test" >
  <br></br> 
 <?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "curs";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

$sql = "SELECT id, name, vinzare, cumparare FROM curs";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    // output data of each row
	echo "<table style='width: 90%' >";
	echo "<tr style='color: white'><td>Valuta</td><td>Vinzare</td><td>Cumparare</td></tr>";
    while($row = $result->fetch_assoc()) {
		echo "<tr style='color: white'>";
		echo "<td>" . $row["name"] . "</td>";
		echo "<td>" . $row["vinzare"] . "</td>";
		echo "<td>" . $row["cumparare"] . "</td>";
        echo "</tr>" ;
    }
	echo "</table>";
} else {
    echo "0 results";
}
$conn->close();
?> 
             
<footer id="footerLLL">

<p>Entertainment: <a align="center" href="http://gossipgirl123w.wix.com/gossipgirl" title="Site Gossipgirl " bgcolor="#FF0000">Gossipgirl</a></p>   
<a href="mailto:gossipgirl123w@gmail.com?subject=Nelamuriri" title="Trimite nelamuriri">Ajutor </a></br>
<a href="http://www.google.com/" target="_blank" title="Mergi pe situl Google">Google </a>
</footer>
</body>
</html>
