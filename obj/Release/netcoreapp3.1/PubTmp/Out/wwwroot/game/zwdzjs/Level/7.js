oS.Init({PName:[oPeashooter,oSunFlower,oCherryBomb,oWallNut,oPotatoMine,oSnowPea],ZName:[oZombie,oConeheadZombie,oPoleVaultingZombie],PicArr:function(){var a=oChomper.prototype,b=a.PicArr;return["../wwwroot/game/zwdzjs/images/interface/background1.jpg",b[a.CardGif],b[a.NormalGif]]}(),backgroundImage:"../wwwroot/game/zwdzjs/images/interface/background1.jpg",CanSelectCard:0,LevelName:"关卡 1-7",LargeWaveFlag:{10:$("imgFlag3"),20:$("imgFlag1")},LoadMusic:function(){NewEle("oEmbed","embed","width:0;height:0",{src:"music/Look up at the.swf"},EDAll)}},{ArZ:[oZombie,oZombie,oZombie,oZombie,oZombie,oZombie,oZombie,oConeheadZombie,oConeheadZombie,oPoleVaultingZombie],FlagNum:20,SumToZombie:{1:7,2:10,"default":10},FlagToSumNum:{a1:[3,5,9,10,13,15,19],a2:[1,2,3,10,4,5,6,15]},FlagToMonitor:{9:[ShowLargeWave,0],19:[ShowFinalWave,0]},FlagToEnd:function(){NewImg("imgSF","../wwwroot/game/zwdzjs/images/card/plants/Chomper.png","left:667px;top:220px",EDAll,{onclick:function(){GetNewCard(this,oChomper,8)}});NewImg("PointerUD","../wwwroot/game/zwdzjs/images/interface/PointerDown.gif","top:185px;left:676px",EDAll)}});
