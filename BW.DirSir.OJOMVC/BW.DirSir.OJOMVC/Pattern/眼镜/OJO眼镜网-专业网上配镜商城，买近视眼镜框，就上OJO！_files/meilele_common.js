$(function(){
	/*收藏夹功能*/
	$("#favorite_wb").click(function() {
		var h = "http://"+location.hostname;
		var j = location.title;
		try {
			window.external.addFavorite(h, j);
		} catch (i) {
			try {
				window.sidebar.addPanel(j, h, "");
			} catch (i) {
				alert("对不起，您的浏览器不支持此操作！\n请您使用菜单栏或Ctrl+D收藏丽子。");
			}
     	}
	})
	
	/*宽窄屏判断 start*/
	if(screen.width > 1210 && $(window).width() > 1210)
	{
		$("body").addClass("root_body");
	};
	/*宽窄屏判断 end*/
	
	/*顶部导航下拉效果 start*/
	var isIE = !-[1, ];
    $("#JS_quick_memu").on("mouseenter", ".sncq-item",
    function() {
        $(this).addClass("hover");
        if (isIE) {
            $(this).find(".snc-arrow").addClass("snc-arrow-ie");
        }
    }).on("mouseleave", ".sncq-item",
    function() {
        var a = !-[1, ];
        $(this).removeClass("hover");
        if (a) {
            $(this).find(".snc-arrow").removeClass("snc-arrow-ie");
        }
    });
	/*顶部导航下拉效果 end*/
	
	/*回到顶部效果 start*/
	$("a.back2top").click(function(){	
		$("body,html").animate({
                    scrollTop: 0
		}, 500);
	})
	/*回到顶部效果 end*/
	
	/*头部下拉菜单 start*/
	$("#userinfo-bar li.more-menu").mouseenter(function(){
		$(this).animate(300,function(){
			$(this).addClass("hover");
		})
	})
	
	$("#userinfo-bar li.more-menu").mouseleave(function(){
		$(this).animate(300,function(){
			$(this).removeClass("hover");
		})
	})
	/*头部下拉菜单 end*/
	
	/*购物车鼠标移入效果 start*/
	$("#ECS_CARTINFO").on("mouseenter", function() {
		$("#ECS_CARTINFO").animate(300,function(){
			$("#ECS_CARTINFO").addClass("hover");
		})
	}).on("mouseleave", function() {
		$("#ECS_CARTINFO").animate(300,function(){
			$("#ECS_CARTINFO").removeClass("hover");
		})
	});
	/*购物车鼠标移入效果 end*/
	
	/*分类导航鼠标移入效果 start*/	
	$('#JS_mll_menu_map li').on("mouseenter",function(){
		$(this).addClass("hover").find("em").stop().animate({
                "margin-left": "19px"
            },200);
			var c = $('#JS_mll_menu_map li').find("#JS_sub_recommend");
            if ($(this).hasClass("recommend")) {
                $(this).hasClass("recommend") && c.animate({
                    "padding-left": "11px"
                },
                200).show();
            } else {
                $(this).find(".sub").stop().animate({
                    opacity: "1",
                    "padding-left": "27px"
                },
                200).show();
                c.css("display") != "none" && c.animate({
                },
                200).hide();
            }
	}).on("mouseleave",function(){
		$(this).removeClass("hover").find("em").stop().animate({
                "margin-left": "14px"
            },200);
			$(this).find(".sub").stop().animate({
                opacity: "0.8",
                "padding-left": "17px"
            },
            200).hide();
			var c = $('#JS_mll_menu_map li').find("#JS_sub_recommend");
            if ($(this).hasClass("recommend")) {
                $(this).hasClass("recommend") && c.animate({
                    "padding-left": "11px"
                },
                200).show();
            } else {
                $(this).find(".sub").stop().animate({
                    opacity: "1",
                    "padding-left": "11px"
                },
                200).hide();
                c.css("display") != "block" && c.animate({
                },
                200).show();
            }
	})
	/*分类导航鼠标移入效果 end*/	
	
	/*全部分类下拉 start*/
	$("#JS_mll_header_menu_panel").on("mouseenter",function(){
		$(this).addClass("hover").find(".top").show()
	}).on("mouseleave",function(){
		$(this).removeClass("hover").find(".top").hide()
	})
	/*全部分类下拉 end*/
	
	/*会员中心默认页切换 start*/
	jQuery(".tabs .tabItem").slide({ mainCell:"ul",vis:4,prevCell:".sPrev",nextCell:".sNext",effect:"left"});
	jQuery(".tabs").slide({titCell:".parHd li",mainCell:".parBd"});
	/*会员中心默认页切换 end*/
})


