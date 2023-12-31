﻿namespace TypeLevelNatural

#nowarn "3535"   // allow interfaces with static abstract members

/// Type-level interface that all natural numbers must implement.
type Natural =

    /// Corresponding value.
    static abstract Size : int

/// Type zero.
type Nat0 =
    interface Natural with
        static member Size = 0

/// Type-level successor function.
type Successor<'n when 'n :> Natural>() =
    interface Natural with
        static member Size = 'n.Size + 1

// Define 1, 2, 3, ...
type Nat1 = Successor<Nat0>
type Nat2 = Successor<Nat1>
type Nat3 = Successor<Nat2>
type Nat4 = Successor<Nat3>
type Nat5 = Successor<Nat4>
type Nat6 = Successor<Nat5>
type Nat7 = Successor<Nat6>
type Nat8 = Successor<Nat7>
type Nat9 = Successor<Nat8>
type Nat10 = Successor<Nat9>
type Nat11 = Successor<Nat10>
type Nat12 = Successor<Nat11>
type Nat13 = Successor<Nat12>
type Nat14 = Successor<Nat13>
type Nat15 = Successor<Nat14>
type Nat16 = Successor<Nat15>
type Nat17 = Successor<Nat16>
type Nat18 = Successor<Nat17>
type Nat19 = Successor<Nat18>
type Nat20 = Successor<Nat19>
type Nat21 = Successor<Nat20>
type Nat22 = Successor<Nat21>
type Nat23 = Successor<Nat22>
type Nat24 = Successor<Nat23>
type Nat25 = Successor<Nat24>
type Nat26 = Successor<Nat25>
type Nat27 = Successor<Nat26>
type Nat28 = Successor<Nat27>
type Nat29 = Successor<Nat28>
type Nat30 = Successor<Nat29>
type Nat31 = Successor<Nat30>
type Nat32 = Successor<Nat31>
type Nat33 = Successor<Nat32>
type Nat34 = Successor<Nat33>
type Nat35 = Successor<Nat34>
type Nat36 = Successor<Nat35>
type Nat37 = Successor<Nat36>
type Nat38 = Successor<Nat37>
type Nat39 = Successor<Nat38>
type Nat40 = Successor<Nat39>
type Nat41 = Successor<Nat40>
type Nat42 = Successor<Nat41>
type Nat43 = Successor<Nat42>
type Nat44 = Successor<Nat43>
type Nat45 = Successor<Nat44>
type Nat46 = Successor<Nat45>
type Nat47 = Successor<Nat46>
type Nat48 = Successor<Nat47>
type Nat49 = Successor<Nat48>
type Nat50 = Successor<Nat49>
type Nat51 = Successor<Nat50>
type Nat52 = Successor<Nat51>
type Nat53 = Successor<Nat52>
type Nat54 = Successor<Nat53>
type Nat55 = Successor<Nat54>
type Nat56 = Successor<Nat55>
type Nat57 = Successor<Nat56>
type Nat58 = Successor<Nat57>
type Nat59 = Successor<Nat58>
type Nat60 = Successor<Nat59>
type Nat61 = Successor<Nat60>
type Nat62 = Successor<Nat61>
type Nat63 = Successor<Nat62>
type Nat64 = Successor<Nat63>
type Nat65 = Successor<Nat64>
type Nat66 = Successor<Nat65>
type Nat67 = Successor<Nat66>
type Nat68 = Successor<Nat67>
type Nat69 = Successor<Nat68>
type Nat70 = Successor<Nat69>
type Nat71 = Successor<Nat70>
type Nat72 = Successor<Nat71>
type Nat73 = Successor<Nat72>
type Nat74 = Successor<Nat73>
type Nat75 = Successor<Nat74>
type Nat76 = Successor<Nat75>
type Nat77 = Successor<Nat76>
type Nat78 = Successor<Nat77>
type Nat79 = Successor<Nat78>
type Nat80 = Successor<Nat79>
type Nat81 = Successor<Nat80>
type Nat82 = Successor<Nat81>
type Nat83 = Successor<Nat82>
type Nat84 = Successor<Nat83>
type Nat85 = Successor<Nat84>
type Nat86 = Successor<Nat85>
type Nat87 = Successor<Nat86>
type Nat88 = Successor<Nat87>
type Nat89 = Successor<Nat88>
type Nat90 = Successor<Nat89>
type Nat91 = Successor<Nat90>
type Nat92 = Successor<Nat91>
type Nat93 = Successor<Nat92>
type Nat94 = Successor<Nat93>
type Nat95 = Successor<Nat94>
type Nat96 = Successor<Nat95>
type Nat97 = Successor<Nat96>
type Nat98 = Successor<Nat97>
type Nat99 = Successor<Nat98>
type Nat100 = Successor<Nat99>
type Nat101 = Successor<Nat100>
type Nat102 = Successor<Nat101>
type Nat103 = Successor<Nat102>
type Nat104 = Successor<Nat103>
type Nat105 = Successor<Nat104>
type Nat106 = Successor<Nat105>
type Nat107 = Successor<Nat106>
type Nat108 = Successor<Nat107>
type Nat109 = Successor<Nat108>
type Nat110 = Successor<Nat109>
type Nat111 = Successor<Nat110>
type Nat112 = Successor<Nat111>
type Nat113 = Successor<Nat112>
type Nat114 = Successor<Nat113>
type Nat115 = Successor<Nat114>
type Nat116 = Successor<Nat115>
type Nat117 = Successor<Nat116>
type Nat118 = Successor<Nat117>
type Nat119 = Successor<Nat118>
type Nat120 = Successor<Nat119>
type Nat121 = Successor<Nat120>
type Nat122 = Successor<Nat121>
type Nat123 = Successor<Nat122>
type Nat124 = Successor<Nat123>
type Nat125 = Successor<Nat124>
type Nat126 = Successor<Nat125>
type Nat127 = Successor<Nat126>
type Nat128 = Successor<Nat127>
type Nat129 = Successor<Nat128>
type Nat130 = Successor<Nat129>
type Nat131 = Successor<Nat130>
type Nat132 = Successor<Nat131>
type Nat133 = Successor<Nat132>
type Nat134 = Successor<Nat133>
type Nat135 = Successor<Nat134>
type Nat136 = Successor<Nat135>
type Nat137 = Successor<Nat136>
type Nat138 = Successor<Nat137>
type Nat139 = Successor<Nat138>
type Nat140 = Successor<Nat139>
type Nat141 = Successor<Nat140>
type Nat142 = Successor<Nat141>
type Nat143 = Successor<Nat142>
type Nat144 = Successor<Nat143>
type Nat145 = Successor<Nat144>
type Nat146 = Successor<Nat145>
type Nat147 = Successor<Nat146>
type Nat148 = Successor<Nat147>
type Nat149 = Successor<Nat148>
type Nat150 = Successor<Nat149>
type Nat151 = Successor<Nat150>
type Nat152 = Successor<Nat151>
type Nat153 = Successor<Nat152>
type Nat154 = Successor<Nat153>
type Nat155 = Successor<Nat154>
type Nat156 = Successor<Nat155>
type Nat157 = Successor<Nat156>
type Nat158 = Successor<Nat157>
type Nat159 = Successor<Nat158>
type Nat160 = Successor<Nat159>
type Nat161 = Successor<Nat160>
type Nat162 = Successor<Nat161>
type Nat163 = Successor<Nat162>
type Nat164 = Successor<Nat163>
type Nat165 = Successor<Nat164>
type Nat166 = Successor<Nat165>
type Nat167 = Successor<Nat166>
type Nat168 = Successor<Nat167>
type Nat169 = Successor<Nat168>
type Nat170 = Successor<Nat169>
type Nat171 = Successor<Nat170>
type Nat172 = Successor<Nat171>
type Nat173 = Successor<Nat172>
type Nat174 = Successor<Nat173>
type Nat175 = Successor<Nat174>
type Nat176 = Successor<Nat175>
type Nat177 = Successor<Nat176>
type Nat178 = Successor<Nat177>
type Nat179 = Successor<Nat178>
type Nat180 = Successor<Nat179>
type Nat181 = Successor<Nat180>
type Nat182 = Successor<Nat181>
type Nat183 = Successor<Nat182>
type Nat184 = Successor<Nat183>
type Nat185 = Successor<Nat184>
type Nat186 = Successor<Nat185>
type Nat187 = Successor<Nat186>
type Nat188 = Successor<Nat187>
type Nat189 = Successor<Nat188>
type Nat190 = Successor<Nat189>
type Nat191 = Successor<Nat190>
type Nat192 = Successor<Nat191>
type Nat193 = Successor<Nat192>
type Nat194 = Successor<Nat193>
type Nat195 = Successor<Nat194>
type Nat196 = Successor<Nat195>
type Nat197 = Successor<Nat196>
type Nat198 = Successor<Nat197>
type Nat199 = Successor<Nat198>
type Nat200 = Successor<Nat199>
type Nat201 = Successor<Nat200>
type Nat202 = Successor<Nat201>
type Nat203 = Successor<Nat202>
type Nat204 = Successor<Nat203>
type Nat205 = Successor<Nat204>
type Nat206 = Successor<Nat205>
type Nat207 = Successor<Nat206>
type Nat208 = Successor<Nat207>
type Nat209 = Successor<Nat208>
type Nat210 = Successor<Nat209>
type Nat211 = Successor<Nat210>
type Nat212 = Successor<Nat211>
type Nat213 = Successor<Nat212>
type Nat214 = Successor<Nat213>
type Nat215 = Successor<Nat214>
type Nat216 = Successor<Nat215>
type Nat217 = Successor<Nat216>
type Nat218 = Successor<Nat217>
type Nat219 = Successor<Nat218>
type Nat220 = Successor<Nat219>
type Nat221 = Successor<Nat220>
type Nat222 = Successor<Nat221>
type Nat223 = Successor<Nat222>
type Nat224 = Successor<Nat223>
type Nat225 = Successor<Nat224>
type Nat226 = Successor<Nat225>
type Nat227 = Successor<Nat226>
type Nat228 = Successor<Nat227>
type Nat229 = Successor<Nat228>
type Nat230 = Successor<Nat229>
type Nat231 = Successor<Nat230>
type Nat232 = Successor<Nat231>
type Nat233 = Successor<Nat232>
type Nat234 = Successor<Nat233>
type Nat235 = Successor<Nat234>
type Nat236 = Successor<Nat235>
type Nat237 = Successor<Nat236>
type Nat238 = Successor<Nat237>
type Nat239 = Successor<Nat238>
type Nat240 = Successor<Nat239>
type Nat241 = Successor<Nat240>
type Nat242 = Successor<Nat241>
type Nat243 = Successor<Nat242>
type Nat244 = Successor<Nat243>
type Nat245 = Successor<Nat244>
type Nat246 = Successor<Nat245>
type Nat247 = Successor<Nat246>
type Nat248 = Successor<Nat247>
type Nat249 = Successor<Nat248>
type Nat250 = Successor<Nat249>
type Nat251 = Successor<Nat250>
type Nat252 = Successor<Nat251>
type Nat253 = Successor<Nat252>
type Nat254 = Successor<Nat253>
type Nat255 = Successor<Nat254>
type Nat256 = Successor<Nat255>
type Nat257 = Successor<Nat256>
type Nat258 = Successor<Nat257>
type Nat259 = Successor<Nat258>
type Nat260 = Successor<Nat259>
type Nat261 = Successor<Nat260>
type Nat262 = Successor<Nat261>
type Nat263 = Successor<Nat262>
type Nat264 = Successor<Nat263>
type Nat265 = Successor<Nat264>
type Nat266 = Successor<Nat265>
type Nat267 = Successor<Nat266>
type Nat268 = Successor<Nat267>
type Nat269 = Successor<Nat268>
type Nat270 = Successor<Nat269>
type Nat271 = Successor<Nat270>
type Nat272 = Successor<Nat271>
type Nat273 = Successor<Nat272>
type Nat274 = Successor<Nat273>
type Nat275 = Successor<Nat274>
type Nat276 = Successor<Nat275>
type Nat277 = Successor<Nat276>
type Nat278 = Successor<Nat277>
type Nat279 = Successor<Nat278>
type Nat280 = Successor<Nat279>
type Nat281 = Successor<Nat280>
type Nat282 = Successor<Nat281>
type Nat283 = Successor<Nat282>
type Nat284 = Successor<Nat283>
type Nat285 = Successor<Nat284>
type Nat286 = Successor<Nat285>
type Nat287 = Successor<Nat286>
type Nat288 = Successor<Nat287>
type Nat289 = Successor<Nat288>
type Nat290 = Successor<Nat289>
type Nat291 = Successor<Nat290>
type Nat292 = Successor<Nat291>
type Nat293 = Successor<Nat292>
type Nat294 = Successor<Nat293>
type Nat295 = Successor<Nat294>
type Nat296 = Successor<Nat295>
type Nat297 = Successor<Nat296>
type Nat298 = Successor<Nat297>
type Nat299 = Successor<Nat298>
type Nat300 = Successor<Nat299>
type Nat301 = Successor<Nat300>
type Nat302 = Successor<Nat301>
type Nat303 = Successor<Nat302>
type Nat304 = Successor<Nat303>
type Nat305 = Successor<Nat304>
type Nat306 = Successor<Nat305>
type Nat307 = Successor<Nat306>
type Nat308 = Successor<Nat307>
type Nat309 = Successor<Nat308>
type Nat310 = Successor<Nat309>
type Nat311 = Successor<Nat310>
type Nat312 = Successor<Nat311>
type Nat313 = Successor<Nat312>
type Nat314 = Successor<Nat313>
type Nat315 = Successor<Nat314>
type Nat316 = Successor<Nat315>
type Nat317 = Successor<Nat316>
type Nat318 = Successor<Nat317>
type Nat319 = Successor<Nat318>
type Nat320 = Successor<Nat319>
type Nat321 = Successor<Nat320>
type Nat322 = Successor<Nat321>
type Nat323 = Successor<Nat322>
type Nat324 = Successor<Nat323>
type Nat325 = Successor<Nat324>
type Nat326 = Successor<Nat325>
type Nat327 = Successor<Nat326>
type Nat328 = Successor<Nat327>
type Nat329 = Successor<Nat328>
type Nat330 = Successor<Nat329>
type Nat331 = Successor<Nat330>
type Nat332 = Successor<Nat331>
type Nat333 = Successor<Nat332>
type Nat334 = Successor<Nat333>
type Nat335 = Successor<Nat334>
type Nat336 = Successor<Nat335>
type Nat337 = Successor<Nat336>
type Nat338 = Successor<Nat337>
type Nat339 = Successor<Nat338>
type Nat340 = Successor<Nat339>
type Nat341 = Successor<Nat340>
type Nat342 = Successor<Nat341>
type Nat343 = Successor<Nat342>
type Nat344 = Successor<Nat343>
type Nat345 = Successor<Nat344>
type Nat346 = Successor<Nat345>
type Nat347 = Successor<Nat346>
type Nat348 = Successor<Nat347>
type Nat349 = Successor<Nat348>
type Nat350 = Successor<Nat349>
type Nat351 = Successor<Nat350>
type Nat352 = Successor<Nat351>
type Nat353 = Successor<Nat352>
type Nat354 = Successor<Nat353>
type Nat355 = Successor<Nat354>
type Nat356 = Successor<Nat355>
type Nat357 = Successor<Nat356>
type Nat358 = Successor<Nat357>
type Nat359 = Successor<Nat358>
type Nat360 = Successor<Nat359>
type Nat361 = Successor<Nat360>
type Nat362 = Successor<Nat361>
type Nat363 = Successor<Nat362>
type Nat364 = Successor<Nat363>
type Nat365 = Successor<Nat364>
type Nat366 = Successor<Nat365>
type Nat367 = Successor<Nat366>
type Nat368 = Successor<Nat367>
type Nat369 = Successor<Nat368>
type Nat370 = Successor<Nat369>
type Nat371 = Successor<Nat370>
type Nat372 = Successor<Nat371>
type Nat373 = Successor<Nat372>
type Nat374 = Successor<Nat373>
type Nat375 = Successor<Nat374>
type Nat376 = Successor<Nat375>
type Nat377 = Successor<Nat376>
type Nat378 = Successor<Nat377>
type Nat379 = Successor<Nat378>
type Nat380 = Successor<Nat379>
type Nat381 = Successor<Nat380>
type Nat382 = Successor<Nat381>
type Nat383 = Successor<Nat382>
type Nat384 = Successor<Nat383>
type Nat385 = Successor<Nat384>
type Nat386 = Successor<Nat385>
type Nat387 = Successor<Nat386>
type Nat388 = Successor<Nat387>
type Nat389 = Successor<Nat388>
type Nat390 = Successor<Nat389>
type Nat391 = Successor<Nat390>
type Nat392 = Successor<Nat391>
type Nat393 = Successor<Nat392>
type Nat394 = Successor<Nat393>
type Nat395 = Successor<Nat394>
type Nat396 = Successor<Nat395>
type Nat397 = Successor<Nat396>
type Nat398 = Successor<Nat397>
type Nat399 = Successor<Nat398>
type Nat400 = Successor<Nat399>
type Nat401 = Successor<Nat400>
type Nat402 = Successor<Nat401>
type Nat403 = Successor<Nat402>
type Nat404 = Successor<Nat403>
type Nat405 = Successor<Nat404>
type Nat406 = Successor<Nat405>
type Nat407 = Successor<Nat406>
type Nat408 = Successor<Nat407>
type Nat409 = Successor<Nat408>
type Nat410 = Successor<Nat409>
type Nat411 = Successor<Nat410>
type Nat412 = Successor<Nat411>
type Nat413 = Successor<Nat412>
type Nat414 = Successor<Nat413>
type Nat415 = Successor<Nat414>
type Nat416 = Successor<Nat415>
type Nat417 = Successor<Nat416>
type Nat418 = Successor<Nat417>
type Nat419 = Successor<Nat418>
type Nat420 = Successor<Nat419>
type Nat421 = Successor<Nat420>
type Nat422 = Successor<Nat421>
type Nat423 = Successor<Nat422>
type Nat424 = Successor<Nat423>
type Nat425 = Successor<Nat424>
type Nat426 = Successor<Nat425>
type Nat427 = Successor<Nat426>
type Nat428 = Successor<Nat427>
type Nat429 = Successor<Nat428>
type Nat430 = Successor<Nat429>
type Nat431 = Successor<Nat430>
type Nat432 = Successor<Nat431>
type Nat433 = Successor<Nat432>
type Nat434 = Successor<Nat433>
type Nat435 = Successor<Nat434>
type Nat436 = Successor<Nat435>
type Nat437 = Successor<Nat436>
type Nat438 = Successor<Nat437>
type Nat439 = Successor<Nat438>
type Nat440 = Successor<Nat439>
type Nat441 = Successor<Nat440>
type Nat442 = Successor<Nat441>
type Nat443 = Successor<Nat442>
type Nat444 = Successor<Nat443>
type Nat445 = Successor<Nat444>
type Nat446 = Successor<Nat445>
type Nat447 = Successor<Nat446>
type Nat448 = Successor<Nat447>
type Nat449 = Successor<Nat448>
type Nat450 = Successor<Nat449>
type Nat451 = Successor<Nat450>
type Nat452 = Successor<Nat451>
type Nat453 = Successor<Nat452>
type Nat454 = Successor<Nat453>
type Nat455 = Successor<Nat454>
type Nat456 = Successor<Nat455>
type Nat457 = Successor<Nat456>
type Nat458 = Successor<Nat457>
type Nat459 = Successor<Nat458>
type Nat460 = Successor<Nat459>
type Nat461 = Successor<Nat460>
type Nat462 = Successor<Nat461>
type Nat463 = Successor<Nat462>
type Nat464 = Successor<Nat463>
type Nat465 = Successor<Nat464>
type Nat466 = Successor<Nat465>
type Nat467 = Successor<Nat466>
type Nat468 = Successor<Nat467>
type Nat469 = Successor<Nat468>
type Nat470 = Successor<Nat469>
type Nat471 = Successor<Nat470>
type Nat472 = Successor<Nat471>
type Nat473 = Successor<Nat472>
type Nat474 = Successor<Nat473>
type Nat475 = Successor<Nat474>
type Nat476 = Successor<Nat475>
type Nat477 = Successor<Nat476>
type Nat478 = Successor<Nat477>
type Nat479 = Successor<Nat478>
type Nat480 = Successor<Nat479>
type Nat481 = Successor<Nat480>
type Nat482 = Successor<Nat481>
type Nat483 = Successor<Nat482>
type Nat484 = Successor<Nat483>
type Nat485 = Successor<Nat484>
type Nat486 = Successor<Nat485>
type Nat487 = Successor<Nat486>
type Nat488 = Successor<Nat487>
type Nat489 = Successor<Nat488>
type Nat490 = Successor<Nat489>
type Nat491 = Successor<Nat490>
type Nat492 = Successor<Nat491>
type Nat493 = Successor<Nat492>
type Nat494 = Successor<Nat493>
type Nat495 = Successor<Nat494>
type Nat496 = Successor<Nat495>
type Nat497 = Successor<Nat496>
type Nat498 = Successor<Nat497>
type Nat499 = Successor<Nat498>
type Nat500 = Successor<Nat499>
type Nat501 = Successor<Nat500>
type Nat502 = Successor<Nat501>
type Nat503 = Successor<Nat502>
type Nat504 = Successor<Nat503>
type Nat505 = Successor<Nat504>
type Nat506 = Successor<Nat505>
type Nat507 = Successor<Nat506>
type Nat508 = Successor<Nat507>
type Nat509 = Successor<Nat508>
type Nat510 = Successor<Nat509>
type Nat511 = Successor<Nat510>
type Nat512 = Successor<Nat511>
type Nat513 = Successor<Nat512>
type Nat514 = Successor<Nat513>
type Nat515 = Successor<Nat514>
type Nat516 = Successor<Nat515>
type Nat517 = Successor<Nat516>
type Nat518 = Successor<Nat517>
type Nat519 = Successor<Nat518>
type Nat520 = Successor<Nat519>
type Nat521 = Successor<Nat520>
type Nat522 = Successor<Nat521>
type Nat523 = Successor<Nat522>
type Nat524 = Successor<Nat523>
type Nat525 = Successor<Nat524>
type Nat526 = Successor<Nat525>
type Nat527 = Successor<Nat526>
type Nat528 = Successor<Nat527>
type Nat529 = Successor<Nat528>
type Nat530 = Successor<Nat529>
type Nat531 = Successor<Nat530>
type Nat532 = Successor<Nat531>
type Nat533 = Successor<Nat532>
type Nat534 = Successor<Nat533>
type Nat535 = Successor<Nat534>
type Nat536 = Successor<Nat535>
type Nat537 = Successor<Nat536>
type Nat538 = Successor<Nat537>
type Nat539 = Successor<Nat538>
type Nat540 = Successor<Nat539>
type Nat541 = Successor<Nat540>
type Nat542 = Successor<Nat541>
type Nat543 = Successor<Nat542>
type Nat544 = Successor<Nat543>
type Nat545 = Successor<Nat544>
type Nat546 = Successor<Nat545>
type Nat547 = Successor<Nat546>
type Nat548 = Successor<Nat547>
type Nat549 = Successor<Nat548>
type Nat550 = Successor<Nat549>
type Nat551 = Successor<Nat550>
type Nat552 = Successor<Nat551>
type Nat553 = Successor<Nat552>
type Nat554 = Successor<Nat553>
type Nat555 = Successor<Nat554>
type Nat556 = Successor<Nat555>
type Nat557 = Successor<Nat556>
type Nat558 = Successor<Nat557>
type Nat559 = Successor<Nat558>
type Nat560 = Successor<Nat559>
type Nat561 = Successor<Nat560>
type Nat562 = Successor<Nat561>
type Nat563 = Successor<Nat562>
type Nat564 = Successor<Nat563>
type Nat565 = Successor<Nat564>
type Nat566 = Successor<Nat565>
type Nat567 = Successor<Nat566>
type Nat568 = Successor<Nat567>
type Nat569 = Successor<Nat568>
type Nat570 = Successor<Nat569>
type Nat571 = Successor<Nat570>
type Nat572 = Successor<Nat571>
type Nat573 = Successor<Nat572>
type Nat574 = Successor<Nat573>
type Nat575 = Successor<Nat574>
type Nat576 = Successor<Nat575>
type Nat577 = Successor<Nat576>
type Nat578 = Successor<Nat577>
type Nat579 = Successor<Nat578>
type Nat580 = Successor<Nat579>
type Nat581 = Successor<Nat580>
type Nat582 = Successor<Nat581>
type Nat583 = Successor<Nat582>
type Nat584 = Successor<Nat583>
type Nat585 = Successor<Nat584>
type Nat586 = Successor<Nat585>
type Nat587 = Successor<Nat586>
type Nat588 = Successor<Nat587>
type Nat589 = Successor<Nat588>
type Nat590 = Successor<Nat589>
type Nat591 = Successor<Nat590>
type Nat592 = Successor<Nat591>
type Nat593 = Successor<Nat592>
type Nat594 = Successor<Nat593>
type Nat595 = Successor<Nat594>
type Nat596 = Successor<Nat595>
type Nat597 = Successor<Nat596>
type Nat598 = Successor<Nat597>
type Nat599 = Successor<Nat598>
type Nat600 = Successor<Nat599>
type Nat601 = Successor<Nat600>
type Nat602 = Successor<Nat601>
type Nat603 = Successor<Nat602>
type Nat604 = Successor<Nat603>
type Nat605 = Successor<Nat604>
type Nat606 = Successor<Nat605>
type Nat607 = Successor<Nat606>
type Nat608 = Successor<Nat607>
type Nat609 = Successor<Nat608>
type Nat610 = Successor<Nat609>
type Nat611 = Successor<Nat610>
type Nat612 = Successor<Nat611>
type Nat613 = Successor<Nat612>
type Nat614 = Successor<Nat613>
type Nat615 = Successor<Nat614>
type Nat616 = Successor<Nat615>
type Nat617 = Successor<Nat616>
type Nat618 = Successor<Nat617>
type Nat619 = Successor<Nat618>
type Nat620 = Successor<Nat619>
type Nat621 = Successor<Nat620>
type Nat622 = Successor<Nat621>
type Nat623 = Successor<Nat622>
type Nat624 = Successor<Nat623>
type Nat625 = Successor<Nat624>
type Nat626 = Successor<Nat625>
type Nat627 = Successor<Nat626>
type Nat628 = Successor<Nat627>
type Nat629 = Successor<Nat628>
type Nat630 = Successor<Nat629>
type Nat631 = Successor<Nat630>
type Nat632 = Successor<Nat631>
type Nat633 = Successor<Nat632>
type Nat634 = Successor<Nat633>
type Nat635 = Successor<Nat634>
type Nat636 = Successor<Nat635>
type Nat637 = Successor<Nat636>
type Nat638 = Successor<Nat637>
type Nat639 = Successor<Nat638>
type Nat640 = Successor<Nat639>
type Nat641 = Successor<Nat640>
type Nat642 = Successor<Nat641>
type Nat643 = Successor<Nat642>
type Nat644 = Successor<Nat643>
type Nat645 = Successor<Nat644>
type Nat646 = Successor<Nat645>
type Nat647 = Successor<Nat646>
type Nat648 = Successor<Nat647>
type Nat649 = Successor<Nat648>
type Nat650 = Successor<Nat649>
type Nat651 = Successor<Nat650>
type Nat652 = Successor<Nat651>
type Nat653 = Successor<Nat652>
type Nat654 = Successor<Nat653>
type Nat655 = Successor<Nat654>
type Nat656 = Successor<Nat655>
type Nat657 = Successor<Nat656>
type Nat658 = Successor<Nat657>
type Nat659 = Successor<Nat658>
type Nat660 = Successor<Nat659>
type Nat661 = Successor<Nat660>
type Nat662 = Successor<Nat661>
type Nat663 = Successor<Nat662>
type Nat664 = Successor<Nat663>
type Nat665 = Successor<Nat664>
type Nat666 = Successor<Nat665>
type Nat667 = Successor<Nat666>
type Nat668 = Successor<Nat667>
type Nat669 = Successor<Nat668>
type Nat670 = Successor<Nat669>
type Nat671 = Successor<Nat670>
type Nat672 = Successor<Nat671>
type Nat673 = Successor<Nat672>
type Nat674 = Successor<Nat673>
type Nat675 = Successor<Nat674>
type Nat676 = Successor<Nat675>
type Nat677 = Successor<Nat676>
type Nat678 = Successor<Nat677>
type Nat679 = Successor<Nat678>
type Nat680 = Successor<Nat679>
type Nat681 = Successor<Nat680>
type Nat682 = Successor<Nat681>
type Nat683 = Successor<Nat682>
type Nat684 = Successor<Nat683>
type Nat685 = Successor<Nat684>
type Nat686 = Successor<Nat685>
type Nat687 = Successor<Nat686>
type Nat688 = Successor<Nat687>
type Nat689 = Successor<Nat688>
type Nat690 = Successor<Nat689>
type Nat691 = Successor<Nat690>
type Nat692 = Successor<Nat691>
type Nat693 = Successor<Nat692>
type Nat694 = Successor<Nat693>
type Nat695 = Successor<Nat694>
type Nat696 = Successor<Nat695>
type Nat697 = Successor<Nat696>
type Nat698 = Successor<Nat697>
type Nat699 = Successor<Nat698>
type Nat700 = Successor<Nat699>
type Nat701 = Successor<Nat700>
type Nat702 = Successor<Nat701>
type Nat703 = Successor<Nat702>
type Nat704 = Successor<Nat703>
type Nat705 = Successor<Nat704>
type Nat706 = Successor<Nat705>
type Nat707 = Successor<Nat706>
type Nat708 = Successor<Nat707>
type Nat709 = Successor<Nat708>
type Nat710 = Successor<Nat709>
type Nat711 = Successor<Nat710>
type Nat712 = Successor<Nat711>
type Nat713 = Successor<Nat712>
type Nat714 = Successor<Nat713>
type Nat715 = Successor<Nat714>
type Nat716 = Successor<Nat715>
type Nat717 = Successor<Nat716>
type Nat718 = Successor<Nat717>
type Nat719 = Successor<Nat718>
type Nat720 = Successor<Nat719>
type Nat721 = Successor<Nat720>
type Nat722 = Successor<Nat721>
type Nat723 = Successor<Nat722>
type Nat724 = Successor<Nat723>
type Nat725 = Successor<Nat724>
type Nat726 = Successor<Nat725>
type Nat727 = Successor<Nat726>
type Nat728 = Successor<Nat727>
type Nat729 = Successor<Nat728>
type Nat730 = Successor<Nat729>
type Nat731 = Successor<Nat730>
type Nat732 = Successor<Nat731>
type Nat733 = Successor<Nat732>
type Nat734 = Successor<Nat733>
type Nat735 = Successor<Nat734>
type Nat736 = Successor<Nat735>
type Nat737 = Successor<Nat736>
type Nat738 = Successor<Nat737>
type Nat739 = Successor<Nat738>
type Nat740 = Successor<Nat739>
type Nat741 = Successor<Nat740>
type Nat742 = Successor<Nat741>
type Nat743 = Successor<Nat742>
type Nat744 = Successor<Nat743>
type Nat745 = Successor<Nat744>
type Nat746 = Successor<Nat745>
type Nat747 = Successor<Nat746>
type Nat748 = Successor<Nat747>
type Nat749 = Successor<Nat748>
type Nat750 = Successor<Nat749>
type Nat751 = Successor<Nat750>
type Nat752 = Successor<Nat751>
type Nat753 = Successor<Nat752>
type Nat754 = Successor<Nat753>
type Nat755 = Successor<Nat754>
type Nat756 = Successor<Nat755>
type Nat757 = Successor<Nat756>
type Nat758 = Successor<Nat757>
type Nat759 = Successor<Nat758>
type Nat760 = Successor<Nat759>
type Nat761 = Successor<Nat760>
type Nat762 = Successor<Nat761>
type Nat763 = Successor<Nat762>
type Nat764 = Successor<Nat763>
type Nat765 = Successor<Nat764>
type Nat766 = Successor<Nat765>
type Nat767 = Successor<Nat766>
type Nat768 = Successor<Nat767>
type Nat769 = Successor<Nat768>
type Nat770 = Successor<Nat769>
type Nat771 = Successor<Nat770>
type Nat772 = Successor<Nat771>
type Nat773 = Successor<Nat772>
type Nat774 = Successor<Nat773>
type Nat775 = Successor<Nat774>
type Nat776 = Successor<Nat775>
type Nat777 = Successor<Nat776>
type Nat778 = Successor<Nat777>
type Nat779 = Successor<Nat778>
type Nat780 = Successor<Nat779>
type Nat781 = Successor<Nat780>
type Nat782 = Successor<Nat781>
type Nat783 = Successor<Nat782>
type Nat784 = Successor<Nat783>
type Nat785 = Successor<Nat784>
type Nat786 = Successor<Nat785>
type Nat787 = Successor<Nat786>
type Nat788 = Successor<Nat787>
type Nat789 = Successor<Nat788>
type Nat790 = Successor<Nat789>
type Nat791 = Successor<Nat790>
type Nat792 = Successor<Nat791>
type Nat793 = Successor<Nat792>
type Nat794 = Successor<Nat793>
type Nat795 = Successor<Nat794>
type Nat796 = Successor<Nat795>
type Nat797 = Successor<Nat796>
type Nat798 = Successor<Nat797>
type Nat799 = Successor<Nat798>
type Nat800 = Successor<Nat799>
type Nat801 = Successor<Nat800>
type Nat802 = Successor<Nat801>
type Nat803 = Successor<Nat802>
type Nat804 = Successor<Nat803>
type Nat805 = Successor<Nat804>
type Nat806 = Successor<Nat805>
type Nat807 = Successor<Nat806>
type Nat808 = Successor<Nat807>
type Nat809 = Successor<Nat808>
type Nat810 = Successor<Nat809>
type Nat811 = Successor<Nat810>
type Nat812 = Successor<Nat811>
type Nat813 = Successor<Nat812>
type Nat814 = Successor<Nat813>
type Nat815 = Successor<Nat814>
type Nat816 = Successor<Nat815>
type Nat817 = Successor<Nat816>
type Nat818 = Successor<Nat817>
type Nat819 = Successor<Nat818>
type Nat820 = Successor<Nat819>
type Nat821 = Successor<Nat820>
type Nat822 = Successor<Nat821>
type Nat823 = Successor<Nat822>
type Nat824 = Successor<Nat823>
type Nat825 = Successor<Nat824>
type Nat826 = Successor<Nat825>
type Nat827 = Successor<Nat826>
type Nat828 = Successor<Nat827>
type Nat829 = Successor<Nat828>
type Nat830 = Successor<Nat829>
type Nat831 = Successor<Nat830>
type Nat832 = Successor<Nat831>
type Nat833 = Successor<Nat832>
type Nat834 = Successor<Nat833>
type Nat835 = Successor<Nat834>
type Nat836 = Successor<Nat835>
type Nat837 = Successor<Nat836>
type Nat838 = Successor<Nat837>
type Nat839 = Successor<Nat838>
type Nat840 = Successor<Nat839>
type Nat841 = Successor<Nat840>
type Nat842 = Successor<Nat841>
type Nat843 = Successor<Nat842>
type Nat844 = Successor<Nat843>
type Nat845 = Successor<Nat844>
type Nat846 = Successor<Nat845>
type Nat847 = Successor<Nat846>
type Nat848 = Successor<Nat847>
type Nat849 = Successor<Nat848>
type Nat850 = Successor<Nat849>
type Nat851 = Successor<Nat850>
type Nat852 = Successor<Nat851>
type Nat853 = Successor<Nat852>
type Nat854 = Successor<Nat853>
type Nat855 = Successor<Nat854>
type Nat856 = Successor<Nat855>
type Nat857 = Successor<Nat856>
type Nat858 = Successor<Nat857>
type Nat859 = Successor<Nat858>
type Nat860 = Successor<Nat859>
type Nat861 = Successor<Nat860>
type Nat862 = Successor<Nat861>
type Nat863 = Successor<Nat862>
type Nat864 = Successor<Nat863>
type Nat865 = Successor<Nat864>
type Nat866 = Successor<Nat865>
type Nat867 = Successor<Nat866>
type Nat868 = Successor<Nat867>
type Nat869 = Successor<Nat868>
type Nat870 = Successor<Nat869>
type Nat871 = Successor<Nat870>
type Nat872 = Successor<Nat871>
type Nat873 = Successor<Nat872>
type Nat874 = Successor<Nat873>
type Nat875 = Successor<Nat874>
type Nat876 = Successor<Nat875>
type Nat877 = Successor<Nat876>
type Nat878 = Successor<Nat877>
type Nat879 = Successor<Nat878>
type Nat880 = Successor<Nat879>
type Nat881 = Successor<Nat880>
type Nat882 = Successor<Nat881>
type Nat883 = Successor<Nat882>
type Nat884 = Successor<Nat883>
type Nat885 = Successor<Nat884>
type Nat886 = Successor<Nat885>
type Nat887 = Successor<Nat886>
type Nat888 = Successor<Nat887>
type Nat889 = Successor<Nat888>
type Nat890 = Successor<Nat889>
type Nat891 = Successor<Nat890>
type Nat892 = Successor<Nat891>
type Nat893 = Successor<Nat892>
type Nat894 = Successor<Nat893>
type Nat895 = Successor<Nat894>
type Nat896 = Successor<Nat895>
type Nat897 = Successor<Nat896>
type Nat898 = Successor<Nat897>
type Nat899 = Successor<Nat898>
type Nat900 = Successor<Nat899>
type Nat901 = Successor<Nat900>
type Nat902 = Successor<Nat901>
type Nat903 = Successor<Nat902>
type Nat904 = Successor<Nat903>
type Nat905 = Successor<Nat904>
type Nat906 = Successor<Nat905>
type Nat907 = Successor<Nat906>
type Nat908 = Successor<Nat907>
type Nat909 = Successor<Nat908>
type Nat910 = Successor<Nat909>
type Nat911 = Successor<Nat910>
type Nat912 = Successor<Nat911>
type Nat913 = Successor<Nat912>
type Nat914 = Successor<Nat913>
type Nat915 = Successor<Nat914>
type Nat916 = Successor<Nat915>
type Nat917 = Successor<Nat916>
type Nat918 = Successor<Nat917>
type Nat919 = Successor<Nat918>
type Nat920 = Successor<Nat919>
type Nat921 = Successor<Nat920>
type Nat922 = Successor<Nat921>
type Nat923 = Successor<Nat922>
type Nat924 = Successor<Nat923>
type Nat925 = Successor<Nat924>
type Nat926 = Successor<Nat925>
type Nat927 = Successor<Nat926>
type Nat928 = Successor<Nat927>
type Nat929 = Successor<Nat928>
type Nat930 = Successor<Nat929>
type Nat931 = Successor<Nat930>
type Nat932 = Successor<Nat931>
type Nat933 = Successor<Nat932>
type Nat934 = Successor<Nat933>
type Nat935 = Successor<Nat934>
type Nat936 = Successor<Nat935>
type Nat937 = Successor<Nat936>
type Nat938 = Successor<Nat937>
type Nat939 = Successor<Nat938>
type Nat940 = Successor<Nat939>
type Nat941 = Successor<Nat940>
type Nat942 = Successor<Nat941>
type Nat943 = Successor<Nat942>
type Nat944 = Successor<Nat943>
type Nat945 = Successor<Nat944>
type Nat946 = Successor<Nat945>
type Nat947 = Successor<Nat946>
type Nat948 = Successor<Nat947>
type Nat949 = Successor<Nat948>
type Nat950 = Successor<Nat949>
type Nat951 = Successor<Nat950>
type Nat952 = Successor<Nat951>
type Nat953 = Successor<Nat952>
type Nat954 = Successor<Nat953>
type Nat955 = Successor<Nat954>
type Nat956 = Successor<Nat955>
type Nat957 = Successor<Nat956>
type Nat958 = Successor<Nat957>
type Nat959 = Successor<Nat958>
type Nat960 = Successor<Nat959>
type Nat961 = Successor<Nat960>
type Nat962 = Successor<Nat961>
type Nat963 = Successor<Nat962>
type Nat964 = Successor<Nat963>
type Nat965 = Successor<Nat964>
type Nat966 = Successor<Nat965>
type Nat967 = Successor<Nat966>
type Nat968 = Successor<Nat967>
type Nat969 = Successor<Nat968>
type Nat970 = Successor<Nat969>
type Nat971 = Successor<Nat970>
type Nat972 = Successor<Nat971>
type Nat973 = Successor<Nat972>
type Nat974 = Successor<Nat973>
type Nat975 = Successor<Nat974>
type Nat976 = Successor<Nat975>
type Nat977 = Successor<Nat976>
type Nat978 = Successor<Nat977>
type Nat979 = Successor<Nat978>
type Nat980 = Successor<Nat979>
type Nat981 = Successor<Nat980>
type Nat982 = Successor<Nat981>
type Nat983 = Successor<Nat982>
type Nat984 = Successor<Nat983>
type Nat985 = Successor<Nat984>
type Nat986 = Successor<Nat985>
type Nat987 = Successor<Nat986>
type Nat988 = Successor<Nat987>
type Nat989 = Successor<Nat988>
type Nat990 = Successor<Nat989>
type Nat991 = Successor<Nat990>
type Nat992 = Successor<Nat991>
type Nat993 = Successor<Nat992>
type Nat994 = Successor<Nat993>
type Nat995 = Successor<Nat994>
type Nat996 = Successor<Nat995>
type Nat997 = Successor<Nat996>
type Nat998 = Successor<Nat997>
type Nat999 = Successor<Nat998>
type Nat1000 = Successor<Nat999>
type Nat1001 = Successor<Nat1000>
type Nat1002 = Successor<Nat1001>
type Nat1003 = Successor<Nat1002>
type Nat1004 = Successor<Nat1003>
type Nat1005 = Successor<Nat1004>
type Nat1006 = Successor<Nat1005>
type Nat1007 = Successor<Nat1006>
type Nat1008 = Successor<Nat1007>
type Nat1009 = Successor<Nat1008>
type Nat1010 = Successor<Nat1009>
type Nat1011 = Successor<Nat1010>
type Nat1012 = Successor<Nat1011>
type Nat1013 = Successor<Nat1012>
type Nat1014 = Successor<Nat1013>
type Nat1015 = Successor<Nat1014>
type Nat1016 = Successor<Nat1015>
type Nat1017 = Successor<Nat1016>
type Nat1018 = Successor<Nat1017>
type Nat1019 = Successor<Nat1018>
type Nat1020 = Successor<Nat1019>
type Nat1021 = Successor<Nat1020>
type Nat1022 = Successor<Nat1021>
type Nat1023 = Successor<Nat1022>
type Nat1024 = Successor<Nat1023>
type Nat1025 = Successor<Nat1024>
type Nat1026 = Successor<Nat1025>
type Nat1027 = Successor<Nat1026>
type Nat1028 = Successor<Nat1027>
type Nat1029 = Successor<Nat1028>
type Nat1030 = Successor<Nat1029>
type Nat1031 = Successor<Nat1030>
type Nat1032 = Successor<Nat1031>
type Nat1033 = Successor<Nat1032>
type Nat1034 = Successor<Nat1033>
type Nat1035 = Successor<Nat1034>
type Nat1036 = Successor<Nat1035>
type Nat1037 = Successor<Nat1036>
type Nat1038 = Successor<Nat1037>
type Nat1039 = Successor<Nat1038>
type Nat1040 = Successor<Nat1039>
type Nat1041 = Successor<Nat1040>
type Nat1042 = Successor<Nat1041>
type Nat1043 = Successor<Nat1042>
type Nat1044 = Successor<Nat1043>
type Nat1045 = Successor<Nat1044>
type Nat1046 = Successor<Nat1045>
type Nat1047 = Successor<Nat1046>
type Nat1048 = Successor<Nat1047>
type Nat1049 = Successor<Nat1048>
type Nat1050 = Successor<Nat1049>
type Nat1051 = Successor<Nat1050>
type Nat1052 = Successor<Nat1051>
type Nat1053 = Successor<Nat1052>
type Nat1054 = Successor<Nat1053>
type Nat1055 = Successor<Nat1054>
type Nat1056 = Successor<Nat1055>
type Nat1057 = Successor<Nat1056>
type Nat1058 = Successor<Nat1057>
type Nat1059 = Successor<Nat1058>
type Nat1060 = Successor<Nat1059>
type Nat1061 = Successor<Nat1060>
type Nat1062 = Successor<Nat1061>
type Nat1063 = Successor<Nat1062>
type Nat1064 = Successor<Nat1063>
type Nat1065 = Successor<Nat1064>
type Nat1066 = Successor<Nat1065>
type Nat1067 = Successor<Nat1066>
type Nat1068 = Successor<Nat1067>
type Nat1069 = Successor<Nat1068>
type Nat1070 = Successor<Nat1069>
type Nat1071 = Successor<Nat1070>
type Nat1072 = Successor<Nat1071>
type Nat1073 = Successor<Nat1072>
type Nat1074 = Successor<Nat1073>
type Nat1075 = Successor<Nat1074>
type Nat1076 = Successor<Nat1075>
type Nat1077 = Successor<Nat1076>
type Nat1078 = Successor<Nat1077>
type Nat1079 = Successor<Nat1078>
type Nat1080 = Successor<Nat1079>
type Nat1081 = Successor<Nat1080>
type Nat1082 = Successor<Nat1081>
type Nat1083 = Successor<Nat1082>
type Nat1084 = Successor<Nat1083>
type Nat1085 = Successor<Nat1084>
type Nat1086 = Successor<Nat1085>
type Nat1087 = Successor<Nat1086>
type Nat1088 = Successor<Nat1087>
type Nat1089 = Successor<Nat1088>
type Nat1090 = Successor<Nat1089>
type Nat1091 = Successor<Nat1090>
type Nat1092 = Successor<Nat1091>
type Nat1093 = Successor<Nat1092>
type Nat1094 = Successor<Nat1093>
type Nat1095 = Successor<Nat1094>
type Nat1096 = Successor<Nat1095>
type Nat1097 = Successor<Nat1096>
type Nat1098 = Successor<Nat1097>
type Nat1099 = Successor<Nat1098>
type Nat1100 = Successor<Nat1099>
type Nat1101 = Successor<Nat1100>
type Nat1102 = Successor<Nat1101>
type Nat1103 = Successor<Nat1102>
type Nat1104 = Successor<Nat1103>
type Nat1105 = Successor<Nat1104>
type Nat1106 = Successor<Nat1105>
type Nat1107 = Successor<Nat1106>
type Nat1108 = Successor<Nat1107>
type Nat1109 = Successor<Nat1108>
type Nat1110 = Successor<Nat1109>
type Nat1111 = Successor<Nat1110>
type Nat1112 = Successor<Nat1111>
type Nat1113 = Successor<Nat1112>
type Nat1114 = Successor<Nat1113>
type Nat1115 = Successor<Nat1114>
type Nat1116 = Successor<Nat1115>
type Nat1117 = Successor<Nat1116>
type Nat1118 = Successor<Nat1117>
type Nat1119 = Successor<Nat1118>
type Nat1120 = Successor<Nat1119>
type Nat1121 = Successor<Nat1120>
type Nat1122 = Successor<Nat1121>
type Nat1123 = Successor<Nat1122>
type Nat1124 = Successor<Nat1123>
type Nat1125 = Successor<Nat1124>
type Nat1126 = Successor<Nat1125>
type Nat1127 = Successor<Nat1126>
type Nat1128 = Successor<Nat1127>
type Nat1129 = Successor<Nat1128>
type Nat1130 = Successor<Nat1129>
type Nat1131 = Successor<Nat1130>
type Nat1132 = Successor<Nat1131>
type Nat1133 = Successor<Nat1132>
type Nat1134 = Successor<Nat1133>
type Nat1135 = Successor<Nat1134>
type Nat1136 = Successor<Nat1135>
type Nat1137 = Successor<Nat1136>
type Nat1138 = Successor<Nat1137>
type Nat1139 = Successor<Nat1138>
type Nat1140 = Successor<Nat1139>
type Nat1141 = Successor<Nat1140>
type Nat1142 = Successor<Nat1141>
type Nat1143 = Successor<Nat1142>
type Nat1144 = Successor<Nat1143>
type Nat1145 = Successor<Nat1144>
type Nat1146 = Successor<Nat1145>
type Nat1147 = Successor<Nat1146>
type Nat1148 = Successor<Nat1147>
type Nat1149 = Successor<Nat1148>
type Nat1150 = Successor<Nat1149>
type Nat1151 = Successor<Nat1150>
type Nat1152 = Successor<Nat1151>
type Nat1153 = Successor<Nat1152>
type Nat1154 = Successor<Nat1153>
type Nat1155 = Successor<Nat1154>
type Nat1156 = Successor<Nat1155>
type Nat1157 = Successor<Nat1156>
type Nat1158 = Successor<Nat1157>
type Nat1159 = Successor<Nat1158>
type Nat1160 = Successor<Nat1159>
type Nat1161 = Successor<Nat1160>
type Nat1162 = Successor<Nat1161>
type Nat1163 = Successor<Nat1162>
type Nat1164 = Successor<Nat1163>
type Nat1165 = Successor<Nat1164>
type Nat1166 = Successor<Nat1165>
type Nat1167 = Successor<Nat1166>
type Nat1168 = Successor<Nat1167>
type Nat1169 = Successor<Nat1168>
type Nat1170 = Successor<Nat1169>
type Nat1171 = Successor<Nat1170>
type Nat1172 = Successor<Nat1171>
type Nat1173 = Successor<Nat1172>
type Nat1174 = Successor<Nat1173>
type Nat1175 = Successor<Nat1174>
type Nat1176 = Successor<Nat1175>
type Nat1177 = Successor<Nat1176>
type Nat1178 = Successor<Nat1177>
type Nat1179 = Successor<Nat1178>
type Nat1180 = Successor<Nat1179>
type Nat1181 = Successor<Nat1180>
type Nat1182 = Successor<Nat1181>
type Nat1183 = Successor<Nat1182>
type Nat1184 = Successor<Nat1183>
type Nat1185 = Successor<Nat1184>
type Nat1186 = Successor<Nat1185>
type Nat1187 = Successor<Nat1186>
type Nat1188 = Successor<Nat1187>
type Nat1189 = Successor<Nat1188>
type Nat1190 = Successor<Nat1189>
type Nat1191 = Successor<Nat1190>
type Nat1192 = Successor<Nat1191>
type Nat1193 = Successor<Nat1192>
type Nat1194 = Successor<Nat1193>
type Nat1195 = Successor<Nat1194>
type Nat1196 = Successor<Nat1195>
type Nat1197 = Successor<Nat1196>
type Nat1198 = Successor<Nat1197>
type Nat1199 = Successor<Nat1198>
type Nat1200 = Successor<Nat1199>
