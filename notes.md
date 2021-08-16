# notes

cant tell if these are just examples of how to decode something or an exercise in futility, or the output generator that produces a code to unlock 31TB worth of data, or 100% time sinc/sync?

the original epsilon and omega strings are from the original post examples

## Conversions

converting some text encodings - ASCII / Unicode etc
## Epsilon - decoded base64 byte[] to Ascii

while debugging it looked like a unicode string

> ??C?In???7?7?????????L???G??<g6???????y?>,?Z/???-5?=?????^????j?>4/??u?????,????&?`???.}?I?e?h?MNq???\;???C?N?	??G?6$p????{??i?u|???????N[f?;^?
### same byte[] to Unicode

> 뢙湉㞌꜎옷Ꮶꚿ엠꞊䳖䞵�朼�Ꞑ헀텹ⰾ嫅ꐯ雟㔭᜛㶉㾴趲庉쾁樄㺷⼴韙鄃눂釐먦怘ꒄ⺒녽륉녥轨乍艱좮౜젻빃ሜᰉ苃䜂㚁瀤뿅࣭箭즙쉩甅ꕼ蛃龰ퟍ孎퍦帻팜

### actual translation??, odd nonetheless:

![intredasting](img/epsilon_unicode-to_english.png)

result:

> 뢙湉㞌 옷 Ꮶꚿ 엠 䳖䞵�朼�Ꞑ 헀텹 ⰾ 嫅 ꐯ 雟 㔭᜛㶉 㾴 趱 庉 쾁樄 㺷 wide 韪鄃 눂 % per annum먦 怘 ꒄ⺒녽륉녥 rail at first glance difficult 좮౜젻빃 ሜᰉ 苃 䜂 㚁 瀤 뿅 ࣭ arrow 즙쉩 甅 ꕼ 蛃 龰 ퟍ 孎 퍦 ze 팜

`wide` 

`per annum` 

`rail at first glance difficult` 

`.arrow` 

This is really weird

## Omega - decoded base64 byte[] to Ascii

again... Ascii:

> Ab'???2??!????*+P?+}?]???0????C??H2?X?j??:?|;??_??%???=qX??[?/un	???e_???,OW????t1k??5f???d?????N?	X$???4??V????=m??9??9??vm??X????\WFB?}?yu?.???b??s??i???????rn??p???????d?K<???_??9?b?lJ?"A !???yNw?;?9???\c?`?#?02l?.????.Ey??C?????#???h

### so... same byte[] to Unicode

using the same input byte array to Unicode:

> 扁짜⇙鯸⬪轐紫嶘쫽セ羬䎅駒㉈ިѪ엷뼺ᕼ㬙莶饟◎뚾㶩塱﹛⼘湵뎛彥ᇕ輁ⳋ坏꧵쎉ㅴ荫㗲굦헽ၤץ궡ï鍎堉︤혇ῌ嚕໬֡ᇊ㷐뽭㧕밞㦥趼浶閛峕圏䉆緊ᇴ畹Ƥ턮苟成꧈�槎쯿ꂕꚏ狫烹骥磌醺撴䮲㰛꾾忠髨Ĺꥢ䩬ᤝ脄ย䄐℠颓乹ﭷ눻ﴹ菬捜惀똔눣㈰ꑬ鸮ᯂ엙ฮ౅赹ځ藳鞬ꄣއ棞
Unicode|decrypted0:!詯뇝뉋壇쵡踂鞘韶냑롍渉ᅤ஫Ａ탾ꭧꞛ銋፶ᨻ㫎쑀һ⢀聩灢ᑠ䮭㚮≖㦷魯⑨ࠩ榭ﲣ겄�涘ⷿᬲ࿈캼ᖢ焏筐넠냋矆늀﹟゛癭⿱ف萝㵈ꋱ䁠䁝㥗⯡횲䳝ک꬚⢾쁱᣻

cap after the translattion - more odd
![intredasting](img/omega_unicode-to_english.png)

> Flat짜⇙鯸⬪轐 purple 嶘 쫽 Ã 羬䎅 foal ㉈ި Ѫ 엷뼺 ᕼ 㬙 Siegesbeckiae 饟◎뚾 㶩 Long Valley﹛⼘湵뎛 Mary ᇕ 輁 ⳋ bad ꧵ 쎉ㅴ shadow 㗲 굦헽 ၤץ 궡 ï 鍎 堉 ︤혇 ῃchatter໬֡ᇊ 㷐 뽭 㧕 밞 㦥 趼 浶閛 峕 rings 䉆 tight ᇴ WAN Ƥ 턮 GOU into꧈� Cha 쯿 ꂕꚏ 狫cooking JI 磌 rotor 撴 䮲 㰛 꾾 Zhong 髨 Ĺꥢ 䩬 ᤝ 脄 over 䄐, Inc.post-apocalyptic 乹 ﭷ 눻 ﴹ 菬 press release 惀 똔눣㈰ꑬ owl ᯂ 엙 ฮ౅赹 ځ藳 鞬 ꄣއ 棞
Unicode|decrypted0:!詯뇝뉋 altar 쵡 踂 sheath Shao 냑롍re-quiredᅤ஫A 탾ꭧꞛ 銋 ፶ᨻ 㫎 쑀 һ⢀deaf 灢 ᑠ 䮭 㚮≖㦷 魯 ⑨ࠩ Pavilion ﲣ 겄�涘 ⷿᬲ࿈캼 ᖢ 焏 basket 넠냋矆 늀﹟gall⿱ف dill 㵈 ꋱ 䁠 䁝 㥗⯡횲 䳝 ک꬚⢾쁱᣻

you can read ^^^ - same thing as above etc... no clue beyond this

## interesting though

`Unicode|decrypted0:`

`press relese`

`apocalyptic`

etc... later