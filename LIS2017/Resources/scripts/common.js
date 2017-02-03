function changeVerify(obj){
	$("#code").attr("src",verifyURL + '/' +Math.random());
	return false;
}

function changeSideBar(mainid,subid){		
	document.getElementById(subid).className ="current";
	document.getElementById(mainid).className ="nav-top-item current";
	document.getElementById(mainid).click();
}

function changeSideBarNoSub(mainid){		
	document.getElementById(mainid).className ="nav-top-item no-submenu current";
}