

$(document).ready(function () {
    //回到顶部隐藏
    $(window).scroll(function () {

        if ($(window).scrollTop() > 100) {
            $('.gotop').removeClass('divnone')
        } else if (!$('.gotop').hasClass('divnone')) {
            $('.gotop').addClass('divnone')
        }
    })
    //菜单点击切换
    $('.son.show1').addClass('divshow');
    $('.productlist div').addClass('product');
    $('.product span').addClass('addshopping');
    var currentShow = 'show1';
    var curclkobj = $('.son.show1');
    $('.row.show1').addClass('clickshow');
    $('.father ul li').click(function () {
        $('.catering-left>ul>li').removeClass('clickshow')
        $(this).addClass('clickshow')

        $('.son.' + currentShow).removeClass('divshow');
        currentShow = $(this).attr('class').split(' ')[1];
        $('.son.' + currentShow).addClass('divshow');
    })

    //自动动态更新人气top页
    function Product(name,price){
        this.name= name
        this.price=price
    }
    var productlist = new Array(15)
    var prolength = productlist.length;
    for (var i = 0; i < prolength; i++) {
        productlist[i] = new Product('产品' + i, 'i')
    }
    var proparent = $('.productlist')
    for (var i = 0; i < prolength; i++) {
        proparent.append("<div></div>")
    }
    proparent.children('div').append('<img src="~/img/cfe1.jpg" style="width:80%" class="img-thumbnail" />').append('<span style="position:absolute; right:5px;bottom:0px;">成功</span>').append(
        `<div class="row" style="margin:0px 0px 0px 0px;width:140px">
                            <a class="newprice pull-left"><span class="glyphicon glyphicon-yen"></span><span>12</span></a>
                            <a class="oldprice pull-left"><span class="glyphicon glyphicon-yen"></span>23</a>
                            <a class="addshopping pull-right"><span class="glyphicon glyphicon-plus-sign"></span> 加购</a>
                            <div class="clearfix"></div>
                        </div>`)
    //追加图片
    for (var i = 0; i < prolength; i++) {
        $('.product>img').attr('src',)
    }
    $('.product>img').attr('','')
    proparent.children().addClass('col-md-3 product')

    //购物
    $('.addshopping').parent().prev().hide();
    $('.addshopping').on('click', function () {
        console.log($(this).attr('id'));
        $(this).parent().prev().fadeIn(1000).fadeOut(1000);
    })
    //游戏
    $('.gameimg').css('background', '/img/sky.ipg');
    //我的

    //登录注册
    $('.register').hide();
    $('.showregister').click(function () {
        $('.register').show();
        $('.login').hide();
    })
    $('.showlogin').click(function () {
        $('.login').show();
        $('.register').hide();
    })
})