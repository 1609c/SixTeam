$(function(){
	$search_options = $('#search-options'),
    $items = $search_options.find('.items');
    $items.each(function() {
		var $this = $(this),
			_myHeight = $this.height();
		if (_myHeight > 28 && _myHeight <= 52) {
			$this.parent().height(48);
			$this.next(".more-btn").text('').removeClass('clicked');
		}
		else if(_myHeight > 52)
		{
			$this.parent().height(48);
		}
		else
		{
			$this.parent().height(28);	
			$this.next(".more-btn").text('').removeClass('clicked');
		}
		if (_myHeight > 54) {
			$this.next('a.more-btn').show().on('click', function() {
				var _this = $(this);
				if (_this.hasClass('clicked')) {
					$this.parent().height(48);
					_this.text('更多').removeClass('clicked');
				} else {
					$this.parent().height(_myHeight);
					_this.text('收起').addClass('clicked');
				}
			});
		}
	});	
	
	var $box = $('#priceform'),
    	$form = $box.find('form'),
        $input = $form.find('input[type=text]'),
        $hp = $("#hidden_price");
	$input.on('focus', function() {
        $box.addClass('focus');
     });
	$(document).on("click", function(e) {
        if ($(e.target).parents("#priceform").length == 0) {
 			$box.removeClass('focus');
		}
	});
	
	
	
	/*顶级分类页促销倒计时 start*/
	setInterval(function(){
		$(".endtime").each(function(){
        var obj = $(this);
        var endTime = new Date(parseInt(obj.attr('value')) * 1000);
		var show_day =  obj.attr('showday');
        var nowTime = new Date();
        var nMS=endTime.getTime() - nowTime.getTime() + 28800000;
        var myD=Math.floor(nMS/(1000 * 60 * 60 * 24));
		var myH_show=Math.floor(nMS/(1000*60*60) % 24);
        var myH=Math.floor(nMS/(1000*60*60));
        var myM=Math.floor(nMS/(1000*60)) % 60;
        var myS=Math.floor(nMS/1000) % 60;
        var myMS=Math.floor(nMS/100) % 10;
		var a = myH+myM+myS+myMS;
	
        if(a> 0){
			//<span>10小时43分58秒
			var str = '<span class="time_else"> '+myD+' </span> 天 <span class="time_else"> '+myH_show+' </span> 时 <span class="time_else"> '+myM+' </span> 分';
        }else{
			var str = "已结束！";	
		}

		obj.html(str);
      });
    }, 100);
	/*顶级分类页促销倒计时 end*/
	
	/*分类页品牌鼠标触上去效果 start*/
	$("#JS_brand_overflow").find("li").hover(function() {
     	$(this).addClass("hover");
         },
        function() {
        $(this).removeClass("hover");
    });
	/*分类页品牌鼠标触上去效果 end*/
	
	/*分类页属性筛选 start*/
	(function(){
					var dl=$(".filter").find("dl:gt(0)");
					dl.each(function(){
						var list=$(this).find("dd").find(".shell");
						var h=list.height();
						list.css("height","auto");
						var auto_h=list.height();
						list.css("height",h);
						var td=$(this).find("dd").find("td.more");
						if(auto_h>h){
							td.show();
							var span=$(this).find("jMore span");
							var done=false;
							td.click(function(){
								if(!done){
									list.css("height","auto");
									done=!done;
									$(this).addClass("open");
									span.text("收起");
								}else{
									list.css("height",h);
									done=!done;
									$(this).removeClass("open");
									span.text("更多");
								}
							});
						}else{
							td.hide();
						}
						
					});
				})();
				
				(function(){
					var dl=$(".filter").find(".brand");
					
					var div=dl.find(".shell");
					var h=div.height();
					div.css("height","auto");
					var auto_h=div.height();
					div.css("height",h);
					var td=dl.find("td.more");
					if(auto_h>h){
							td.show();
							var span=dl.find(".jMore span");
							var done=false;
							td.click(function(){
								if(!done){
									div.css("height","auto");
									done=!done;
									$(this).addClass("open");
									span.text("收起");
								}else{
									div.css("height",h);
									done=!done;
									$(this).removeClass("open");
									span.text("更多");
								}
							});
						}else{
							td.hide();
						}
				})();
				
				(function(){
					var dl=$(".filter").find("dl");
					var done=false;
					var hide=function(){
						for(var i=4;i<dl.length;i++){
							dl.eq(i).hide();
						}
					}
					hide();
					var show=function(){
						for(var i=0;i<dl.length;i++){
							dl.eq(i).show();
						}
					}
					
					var btn=$(".handle"),btn_text=btn.find("a span");
					btn.click(function(){
						if(!done){
							show();
							done=!done;
							$(this).addClass("open");
							btn_text.text("点击收起");
						}else{
							hide();
							done=!done;
							$(this).removeClass("open");
							btn_text.text("查看更多");
						}
					});	
				})();
	/*分类页属性筛选 end*/
	$.lazyImg.start("both", {
		attributeTag: window.isWideScreen ? ["data-wide-src", "data-src"] : "data-src"
	});
	
	/*分类商品鼠标触上去效果 start*/
	$("#JS_list_panel").on("mouseenter", ".g-item",
    function() {
        $(this).addClass("g-hover");
    }).on("mouseleave", ".g-item",
    function() {
        $(this).removeClass("g-hover");
    });
	/*分类商品鼠标触上去效果 end*/
	
})
