<?php

	require_once('Models/DbModel.php');
	$con= new DbModel;
	$con->connect();
		require_once('Models/AdminModel.php');
	$ad= new AdminModel;	
	require_once('Models/IndexModel.php');
	$model= new IndexModel;
	require_once('Models/KhachhangModel.php');
	$kh= new KhachhangModel;




	if(isset($_GET['controller'])){
		$controller=$_GET['controller'];
	}
	else{
		$controller='home1';
	}

	switch ($controller) {
		case 'index':{
			require_once('Controllers/index.php');
			break;
		}
		case 'home1':{
require_once('Controllers/home1.php');
			break;
		}
			
	}
	
?>
