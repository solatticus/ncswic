# ncswic

whole rabbits

notes are in [notes.md](notes.md)

could be a 'decoder' down the road

- right now just decodes and converts to `ascii` and `unicode` epsilon and omega "test"? data... 

## why

intriguing posts

## origin posts

two strings in the posts:
  * Epsilon
  * Omega
  * Delta (kidding)

### Aug 13, 2021
```
]FOLLQW[.THE.]YELLQW[
[BRICK[>][ROAD]
_INSPE[CT_IN]SPECT_
[CQDE]RS[B]CQDIN
{/\/\}[AGENTS].[ATT]RACT
[N]IGHT{F}IGHT>{BETA}DATA[
[T]IME[LESS]

N.C.S.W.I.C.

John McAfee.
```

```
[UP]
[DOWN]
[LEFT]
[RIGHT]
[A][A]
]START>TRATS[
_REMEMBER_REMEMBER_
ONLY THE STRONG SURVIVE;
VVATCH_THE_VVATER:

John McAfee.
```

```csharp
    using System;
    using System.Text;
    using System.IO;
    using System.Security.Cryptography;
        
    public class Program
    {
    public static void Main()
    {
    Console.WriteLine("https//opensea[.]io/collection/contingency-protocol-44924");
    Console.WriteLine();
    
    //CONTINGENCY PROTOCOL 44924 COLLECTION DESCRIPTION
    //MD5: 346257E94DA2E0D0D0F54AA397D291F0
    //DATA: Q Society
    string collectiondescriptiondecoded = "Q Society";
    MD5 md5Hash = MD5.Create();
    byte[] md5 = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(collectiondescriptiondecoded));
    Console.WriteLine("Verified: [Q Society] = " + BitConverter.ToString(md5).Replace("-", "") + " Initialization Vector or Key or Who the fuck knows? LULZZZ
    Console.WriteLine();
    
    //SQME KEYS TO TEST  
    byte[] testkey0 = Encoding.UTF8.GetBytes("rustyshackleford");
    byte[] testkey1 = Encoding.UTF8.GetBytes("Q H7^PZBVTpZ7302");  
    //https//www[.]britbonglogpost[.]com/978ea96f-2740-4ea6-b1d0-288f11a48ff7.jpg
    byte[] testkey2 = HexStringToByteArray("978ea96f-2740-4ea6-b1d0-288f11a48ff7".Replace("-", ""));
```

```csharp
  //NFT IMAGE DESCRIPTIONS - BASE64 ENCODED DATA
  //https[:]//opensea[.]io/assets/0x495f947276749ce646f68ac8c248420045cb7b5e/42715653451494116278904116357368839356782358833774246712130390239617933639681
  string epsilon_b64 = "mbhD5klu/+mMNw6nN8bmE7+m4MWKp9ZMzO61R83YPGc23pCnwNXl6XnRPizFWi+k35YtNRsXiT20P7KNiV6Bz/jwBGq3PjQv2Zd14gORArKA6Cz30JEU9Sa6GGCEpJIufbFJuWWxaI9NTnGCrshcDDvIne9DvhwSTvcJHMOCAkeBNiRwxb/tCK17mclpwgV1fKXDhrCfzddOW2bTO14c0w==";
  
  //https[:]//opensea[.]io/assets/0x495f947276749ce646f68ac8c248420045cb7b5e/42715653451494116278904116357368839356782358833774246712130390238518422011905
  string omega_b64 = "QWIn8NzJMuDZIfibj/MqK1CPK32YXf3KuzCsf4HohUPSmUgyqAdY6moE98U6v3wVGTu2g1+ZziW+tqk9cVif41v+GC91bgnym7NlX9URAY/LLE9X9amJw3Qxa4PyNWat/dVkEOUFoa3vAE6TCVgk/gfWzB8085VW7A6hBcoR0D1tv9U5HrylObyNdm2I6ljim5XVXA9XRkLKffQReXWkAS7R34IQYsipc9jOaf/LlaCPputybuz5cKWaq/q6kbRksksbPL6v4F/omjkBHOJiqWxKHRkEgSIOEEEgIQHqk5h5Tnf7O7I5/eyDXGPAYBS2I7IwMmykLp7CG9nFLg5FDHmNgQZD4vOFrJcjoYcH3mg=";
  
  //DECODE BASE64
  var epsilon = Convert.FromBase64String(epsilon_b64);
  var omega = Convert.FromBase64String(omega_b64);
  
  //AES CRYPTO
  var crypto = new AesCryptographyService();


  1x5e7033fd210f8d7b3e87486ad989732c7943058b
```

### Aug 15, 2021 12:12 AM
```bash
Verified: [Q Society] = 346257E94DA2E0D0D0F54AA397D291F0 Initialization Vector or Key or Who the fuck knows. . .?  LULZZZ

Epsilon: mbhD5klu/+mMNw6nN8bmE7+m4MWKp9ZMzO61R83YPGc23pCnwNXl6XnRPizFWi+k35YtNRsXiT20P7KNiV6Bz/jwBGq3PjQv2Zd14gORArKA6Cz30JEU9Sa6GGCEpJIufbFJuWWxaI9NTnGCrshcDDvIne9DvhwSTvcJHMOCAkeBNiRwxb/tCK17mclpwgV1fKXDhrCfzddOW2bTO14c0w==
B64 Decoded: 99B843E6496EFFE98C370EA737C6E613BFA6E0C58AA7D64CCCEEB547CDD83C6736DE90A7C0D5E5E979D13E2CC55A2FA4DF962D351B17893DB43FB28D895E81CFF8F0046AB73E342FD99775E2039102B280E82CF7D09114F526BA186084A4922E7DB149B965B1688F4D4E7182AEC85C0C3BC89DEF43BE1C124EF7091CC382024781362470C5BFED08AD7B99C969C205757CA5C386B09FCDD74E5B66D33B5E1CD3
To String: CIn7 7 ŊLG<g6ސy>,Z/ߖ-5  =?^ j>4/ٗu  ,Б & `.}IehMNq\ ;ȝC  N     Â G6$pſ {i u|ÆN[f;^ 

Trying Key: 7275737479736861636B6C65666F7264   IV: 346257E94DA2E0D0D0F54AA397D291F0
Decrypted: 05EB21006F8A14EEDDB14BB2C75861CD028E9897F697D1B04DB8FBF5096E4BE66411AB0B21FFFED067AB9BA78B9276133B1ACE3A40C4BB048028698062706014AD4BAE365622A5F6B73939F968242908AD69A3FC84ACCCDD986DFF2D321B4FE1C80FBCCEA2150F71507B20B1CBB07BE9C67780B25FFE9B30A8F76D76F12F41061D84483DF1A260405D405739E12BA4ECB2D6DD4CA90623EE1AABBE2871C0FB18
To String !o ݱKXa ѰM    nKd  !gv ; :@Ļ (ibp` K6V"99h$) iݘm-2 O ΢  qP{ ˰{w_0mv/A  H=`@]@W9+L # (q 

Trying Key: 512048375E505A425654705A37333032   IV: 346257E94DA2E0D0D0F54AA397D291F0
Decrypted: 0A74B97E443A4848352C8FA8A36DFB15AAA33E05BF617002C81C650672969009AB1EB0C952DF2F278CB4ACC0C5FEF1AFA49F9F050B8EE7310BFF91FB9A4608FB26F9AC416D6A64E6FA0E278D693F9EAB3DE4878D5F4A013317A7DB38329925A8EA34E410DC7CCB219A029518B19200CFAEB3FCFFB7E40C3090D2A2C8E04227E2328145BA78DB257CF7DBB6AD89F0CB3017A2534B3FFA31B25C77423CC562380F
To String
t~D:HH5,m > ap  e r     R/'񯤟  1 F &Amjd 'i?=䇍_J 3 82%4 |!  Ϯ 0ҢB'2Ex%|۶0 SK?1\wB<b8 

Trying Key: 978EA96F27404EA6B1D0288F11A48FF7   IV: 346257E94DA2E0D0D0F54AA397D291F0
Decrypted: 89323C94A93FB4E1A06C36760BFE424E634E4C1603A3A6E26BEA4122E1CD1812BE771993397040355D933FC193521D8C90843B8A0383557212CFE41DD2AD590257323A32CBBBAEBC75673121F33F7BB00217A6EBEF89B1732D0848A623ADD111D8C85729DBC75B0C09885CF874CE2E3589ACBAA54B1E675A3E07A6B0BFB2ECB5143995E70C871D3AAEB46F9B33616C15EE42F29FB04F81CD949113992B5B4DE5
To String2<?l6v BNcNL  kA"  w 9p@5]?R ; Ur  ҭY W2:2˻ug1!?{  s- H# W)[     \t.5K gZ>  9  :o3al BO͔ +[M


John McAfee.
```

check the notes.md