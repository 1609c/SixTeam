function MyAlertDiv(content,width,height,title,is_inner)
{
	
	  var is_inner   = (typeof(is_inner) == "undefined") ? 0 : parseInt(is_inner);
	  var _id = 'windowBox';
	  var m = "mask";
	  if (docEle(_id)) document.removeChild(docEle(_id));
	  if (docEle(m)) document.removeChild(docEle(m));
	  //计算上卷元素值
	  var scrollPos; 
	  if (typeof window.pageYOffset != 'undefined') 
	  { 
		scrollPos = window.pageYOffset; 
	  } 
	  else if (typeof document.compatMode != 'undefined' && document.compatMode != 'BackCompat') 
	  { 
		scrollPos = document.documentElement.scrollTop; 
	  } 
	  else if (typeof document.body != 'undefined') 
	  { 
		scrollPos = document.body.scrollTop; 
	  }
	
	  var i = 0;
	  var sel_obj = document.getElementsByTagName('select');
	  while (sel_obj[i])
	  {
		sel_obj[i].style.visibility = "hidden";
		i++;
	  }
	  
	  var i = 0;
	  var sel_obj = document.getElementsByTagName('object');
	  while (sel_obj[i])
	  {
		sel_obj[i].style.visibility = "hidden";
		i++;
	  }
	  
	  var i = 0;
	  var sel_obj = document.getElementsByTagName('embed');
	  while (sel_obj[i])
	  {
		sel_obj[i].style.visibility = "hidden";
		i++;
	  }
	  
	
	  // 新激活图层
	  var newDiv = document.createElement("div");
	  newDiv.id = _id;
	  newDiv.style.width = width+'px';
	  newDiv.style.height = 'auto';
	  
	  newDiv.style.top = (parseInt(scrollPos + 200)) + "px";
	  newDiv.style.left = (parseInt(document.body.offsetWidth) - width) / 2 + "px"; // 屏幕居中
	  newDiv.style.overflow = "auto"; 
	  
	  //newDiv.innerHTML +='<div class="contentTop"></div>'
	  //newDiv.innerHTML +='<table width="100%" border="0" cellspacing="0" cellpadding="0">'
	 // newDiv.innerHTML +='<tr>'
	  //newDiv.innerHTML +='<td width="5" class="contentLeft">&nbsp;</td>'
	  //newDiv.innerHTML +='<td>'
	  
	  if(is_inner==1)
	  {
	  newDiv.innerHTML +='<div id="windowBoxInner"><div class="titbar" id="titbar_1"><span class="dialog_title" id="dialog_title">'+title+'</span><a title="关闭" href="javascript:closeWindowBox()" class="btn_close"></a></div><div class="windowBoxContent">'+content+'</div></div>'
	  }
	  else
	  {
		  newDiv.innerHTML +=content;
	  }
	  
	  //newDiv.innerHTML +='</td>'
	  //newDiv.innerHTML +='<td width="5" class="contentRight">&nbsp;</td>'
	  //newDiv.innerHTML +='</tr>'
	  //newDiv.innerHTML +='</table>'
	  //newDiv.innerHTML +='<div class="contentBottom"></div>'
	  document.body.appendChild(newDiv);
	  var newMask = document.createElement("div");
	  newMask.id = m;
	  newMask.style.position = "absolute";
	  newMask.style.zIndex = "9999";
	  newMask.style.width = document.body.scrollWidth + "px";
	  newMask.style.height = document.body.scrollHeight + "px";
	  newMask.style.top = "0px";
	  newMask.style.left = "0px";
	  newMask.style.background = "#000";
	  newMask.style.filter = "alpha(opacity=30)";
	  newMask.style.opacity = "0.40";
	  document.body.appendChild(newMask);
}
function closeWindowBox() 
{
  document.body.removeChild(docEle('windowBox'));
  document.body.removeChild(docEle('mask'));
  var i = 0;
  var sel_obj = document.getElementsByTagName('select');
  while (sel_obj[i])
  {
    sel_obj[i].style.visibility = "";
    i++;
  }
  
  var i = 0;
	  var sel_obj = document.getElementsByTagName('object');
	  while (sel_obj[i])
	  {
		sel_obj[i].style.visibility = "";
		i++;
	  }
	  
	  var i = 0;
	  var sel_obj = document.getElementsByTagName('embed');
	  while (sel_obj[i])
	  {
		sel_obj[i].style.visibility = "";
		i++;
	  }
  
  
}

function docEle() 
{
  return document.getElementById(arguments[0]) || false;
}