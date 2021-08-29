using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace mcaffee
{
    public class Program
    {
        //rando base64 string:
        // 
        private static string epsilon_b64 = "mbhD5klu/+mMNw6nN8bmE7+m4MWKp9ZMzO61R83YPGc23pCnwNXl6XnRPizFWi+k35YtNRsXiT20P7KNiV6Bz/jwBGq3PjQv2Zd14gORArKA6Cz30JEU9Sa6GGCEpJIufbFJuWWxaI9NTnGCrshcDDvIne9DvhwSTvcJHMOCAkeBNiRwxb/tCK17mclpwgV1fKXDhrCfzddOW2bTO14c0w==";
        private static string omega_b64 = "QWIn8NzJMuDZIfibj/MqK1CPK32YXf3KuzCsf4HohUPSmUgyqAdY6moE98U6v3wVGTu2g1+ZziW+tqk9cVif41v+GC91bgnym7NlX9URAY/LLE9X9amJw3Qxa4PyNWat/dVkEOUFoa3vAE6TCVgk/gfWzB8085VW7A6hBcoR0D1tv9U5HrylObyNdm2I6ljim5XVXA9XRkLKffQReXWkAS7R34IQYsipc9jOaf/LlaCPputybuz5cKWaq/q6kbRksksbPL6v4F/omjkBHOJiqWxKHRkEgSIOEEEgIQHqk5h5Tnf7O7I5/eyDXGPAYBS2I7IwMmykLp7CG9nFLg5FDHmNgQZD4vOFrJcjoYcH3mg=";
        
        //SQME KEYS TO TEST  
        private static byte[] testkey0 = Encoding.UTF8.GetBytes("rustyshackleford"); // example from OP 1: rando text
        private static byte[] testkey1 = Encoding.UTF8.GetBytes("Q H7^PZBVTpZ7302");  // example from OP 2: (still rando rext?) also Q's tripcode on 8k?
        //https//www[.]britbonglogpost[.]com/978ea96f-2740-4ea6-b1d0-288f11a48ff7.jpg
        private static byte[] testkey2 = HexStringToByteArray("978ea96f-2740-4ea6-b1d0-288f11a48ff7".Replace("-", "")); // example 3 - if it's a Guid, remove the dashes?
        //NOTE: How many Q posts have file names like a Guid without the hashes? (thinking there are a few)
        //                                               like `978ea96f27404ea6b1d0288f11a48ff7.jpg` or whatever

        private const string Q_SOCIETY = "Q Society"; 
        static void Main(string[] args)
        {
            var md5Hash = MD5.Create();
            var dataTodecode = Q_SOCIETY;
            var paramkey = string.Empty;

            #region still unused
            /*
                First parameter is the key/iv/whatever

                Second parameter is the data/hash/stuff
            */
            if(args.Any())
            {
                paramkey = args[0];
                if(args.Length == 2)
                    dataTodecode = args[1];
            }

            if(!string.IsNullOrEmpty(paramkey) && !string.IsNullOrEmpty(dataTodecode))
            {
                //usage: 
                // dotnet run mcaffee.dll "paramkey" "data here"
                ProcessFromCommandLine(paramkey, dataTodecode); // encoding param? - doesn't do anything yet... 
            }
            #endregion

            // epsilon was given in the original posts, so was omega
            // Take the base64 string that was provided and un-base64 it...
            // then take that result and interperate it as Unicode

            //DECODE BASE64
            
            // value from the posts 
            var epsilon = Convert.FromBase64String(epsilon_b64);            
                // ??C?In???7\u000e?7??\u0013???????L???G??<g6???????y?>,?Z/???-5\u001b\u0017?=?????^????\u0004j?>4/??u?\u0003?\u0002???,???\u0014?&?\u0018`???.}?I?e?h?MNq???\\\f;???C?\u001c\u0012N?\t\u001c??\u0002G?6$p???\b?{??i?\u0005u|???????N[f?;^\u001c?
            var epsilon_ascii = Encoding.ASCII.GetString(epsilon);          // wtf?
                // 뢙湉㞌꜎옷Ꮶꚿ엠꞊䳖䞵�朼�Ꞑ헀텹ⰾ嫅ꐯ雟㔭\u171b㶉㾴趲庉쾁樄㺷⼴韙鄃눂釐먦怘ꒄ⺒녽륉녥轨乍艱좮\u0c5c젻빃ሜᰉ苃䜂㚁瀤뿅࣭箭즙쉩甅ꕼ蛃龰ퟍ孎퍦帻팜
            var epsilon_unicode = Encoding.Unicode.GetString(epsilon);

            var omega = Convert.FromBase64String(omega_b64); // from the posts -    also what?
                // Ab'???2??!????*+P?+}?]???0?\u007f???C??H2?\aX?j\u0004??:?|\u0015\u0019;??_??%???=qX??[?\u0018/un\t???e_?\u0011\u0001??,OW????t1k??5f???d\u0010?\u0005???\0N?\tX$?\a??\u001f4??V?\u000e?\u0005?\u0011?=m??9\u001e??9??vm??X????\\\u000fWFB?}?\u0011yu?\u0001.???\u0010b??s??i???????rn??p???????d?K\u001b<???_??9\u0001\u001c?b?lJ\u001d\u0019\u0004?\"\u000e\u0010A !\u0001???yNw?;?9???\\c?`\u0014?#?02l?.??\u001b??.\u000eE\fy??\u0006C?????#??\a?h
            var omega_ascii = Encoding.ASCII.GetString(omega);
                // 扁짜⇙鯸r⬪轐紫嶘쫽セ羬䎅駒㉈ިѪ엷뼺ᕼ㬙莶饟◎뚾㶩塱﹛⼘湵뎛彥ᇕ輁ⳋ坏꧵쎉ㅴ荫㗲굦헽ၤץ궡ï鍎堉︤혇ῌ嚕\u0eec֡ᇊ㷐뽭㧕밞㦥趼浶閛峕圏䉆緊ᇴ畹Ƥ턮苟成꧈�槎쯿ꂕꚏ狫烹骥磌醺撴䮲㰛꾾忠髨Ĺꥢ䩬ᤝ脄ย䄐℠颓乹ﭷ눻ﴹ菬捜惀똔눣㈰ꑬ鸮ᯂ엙ฮ\u0c45赹ځ藳鞬ꄣއ棞
            var omega_unicode = Encoding.Unicode.GetString(omega);

            Console.WriteLine($"{nameof(epsilon_ascii)}: {epsilon_ascii}"); //console message       
            File.WriteAllText($"{nameof(epsilon_ascii)}.ascii.txt", epsilon_ascii); // write it to a file

            Console.WriteLine($"{nameof(epsilon_unicode)}: {epsilon_unicode}"); //console message
            File.WriteAllText($"{nameof(epsilon_unicode)}.unicode.txt", epsilon_unicode); // write it to a file

            //TODO: reach out to a service and get it translated? heh

            Console.WriteLine($"{nameof(omega_ascii)}: {omega_ascii}"); //console message       
            File.WriteAllText($"{nameof(omega_ascii)}.ascii.txt", omega_ascii); // write it to a file
            
            Console.WriteLine($"{nameof(omega_unicode)}: {omega_unicode}"); // console message
            File.WriteAllText($"{nameof(omega_unicode)}.unicode.txt", omega_unicode); // write it to a file

            //TODO: reach out to a service and get it translated? heh

            //FWIW: not sure of the goal here, but could be parameterized and used as a decoder??
            //---------------------------------------
            //CONTINGENCY PROTOCOL 44924 COLLECTION DESCRIPTION
            //MD5: 346257E94DA2E0D0D0F54AA397D291F0 
            //          note no dashes
            //DATA: Q Society
            var collectiondescriptiondecoded = "Q Society"; // from OG post
            var md5 = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(collectiondescriptiondecoded));

            Console.WriteLine("Verified: [Q Society] = " + BitConverter.ToString(md5).Replace("-", " ") + " Initialization Vector or Key or Who the fuck knows? LULZZZ");
            Console.WriteLine();

            //DATA: iv5BbDul
            var randoIV = "iv5BbDul"; // text from the Green & White image??? 
            var randoIVMd5 = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(randoIV));

            Console.WriteLine("Verified: [iv5BbDul] = " + BitConverter.ToString(randoIVMd5).Replace("-", " ") + " MD5 hash of the string 'iv5BbDul' ");
            Console.WriteLine();

            var crypto = new AesCryptographyService(); // the crypto class from below

            var decrypted0Bytes = crypto.Decrypt(epsilon, testkey0, md5);   // get the bytes
            var decrypted0 = Encoding.Unicode.GetString(decrypted0Bytes);   // use unicode encoding again?

            // !詯뇝뉋壇쵡踂鞘韶냑롍渉ᅤ஫Ａ탾ꭧꞛ銋፶ᨻ㫎쑀һ⢀聩灢ᑠ䮭㚮≖㦷魯⑨ࠩ榭ﲣ겄�涘ⷿᬲ࿈캼ᖢ焏筐넠냋矆늀﹟゛癭⿱ف萝㵈ꋱ䁠䁝㥗⯡횲䳝ک꬚⢾쁱᣻
            Console.WriteLine($"Original Unicode using '{collectiondescriptiondecoded}' hashed to MD5 as an init vector\n{nameof(decrypted0)}:\n\t{decrypted0}");

            var decryptedRando01Bytes = crypto.Decrypt(epsilon, testkey0, randoIVMd5);  // string -> bytes
            var decrtpytedWithRandoString = Encoding.Unicode.GetString(decryptedRando01Bytes); // bytes -> unicode
            
            // 鶹몦흪ठ镛꯴퐤�踂鞘韶냑롍渉ᅤ஫Ａ탾ꭧꞛ銋፶ᨻ㫎쑀һ⢀聩灢ᑠ䮭㚮≖㦷魯⑨ࠩ榭ﲣ겄�涘ⷿᬲ࿈캼ᖢ焏筐넠냋矆늀﹟゛癭⿱ف萝㵈ꋱ䁠䁝㥗⯡횲䳝ک꬚⢾쁱᣻
            Console.WriteLine($"Gren/White Text using '{randoIV}' hashed to MD5 as an init vector\n{nameof(decrtpytedWithRandoString)}:\n\t{decrtpytedWithRandoString}");

            var newDecryptedKey0 = crypto.Decrypt(epsilon, testkey0, randoIVMd5); // just seeing what the text from that green/white image results in
            Console.WriteLine("Trying Key:\n\t" + BitConverter.ToString(newDecryptedKey0).Replace("-", "") + "   IV0: " + BitConverter.ToString(randoIVMd5).Replace("-", ""));
            Console.WriteLine("To Unicode String:\n\t" + Encoding.Unicode.GetString(newDecryptedKey0));
            Console.WriteLine();

            #region initial "test" stuff from the posts
            // Console.WriteLine("Epsilon: " + epsilon_b64);
            // Console.WriteLine("B64 Decoded: " + BitConverter.ToString(epsilon).Replace("-", ""));
            // Console.WriteLine("To String: " + Encoding.UTF8.GetString(epsilon));
            // Console.WriteLine();

            // var decrypted0 = crypto.Decrypt(epsilon, testkey0, md5);
            // Console.WriteLine("Trying Key: " + BitConverter.ToString(testkey0).Replace("-", "") + "   IV0: " + BitConverter.ToString(md5).Replace("-", ""));
            // Console.WriteLine("Decrypted: " + BitConverter.ToString(decrypted0).Replace("-", ""));
            // Console.WriteLine("To String" + Encoding.UTF8.GetString(decrypted0));
            // Console.WriteLine();
            
            // var decrypted1 = crypto.Decrypt(epsilon, testkey1, md5);
            // Console.WriteLine("Trying Key: " + BitConverter.ToString(testkey1).Replace("-", "") + "   IV1: " + BitConverter.ToString(md5).Replace("-", ""));
            // Console.WriteLine("Decrypted: " + BitConverter.ToString(decrypted1).Replace("-", ""));
            // Console.WriteLine("To String" + Encoding.UTF8.GetString(decrypted1));  
            // Console.WriteLine();
            
            // var decrypted2 = crypto.Decrypt(epsilon, testkey2, md5);
            // Console.WriteLine("Trying Key: " + BitConverter.ToString(testkey2).Replace("-", "") + "   IV2: " + BitConverter.ToString(md5).Replace("-", ""));
            // Console.WriteLine("Decrypted: " + BitConverter.ToString(decrypted2).Replace("-", ""));
            // Console.WriteLine("To String" + Encoding.UTF8.GetString(decrypted2));  
            // Console.WriteLine();
                        
            // Console.Read();
            #endregion
        }

        private static void ProcessFromCommandLine(string paramkey, string dataTodecode)
        {
            Console.WriteLine($"{nameof(paramkey)}:{paramkey},{nameof(dataTodecode)}:{dataTodecode}");
        }

        public static byte[] HexStringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
            bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
    }
    public class AesCryptographyService
    {
        public byte[] Encrypt(byte[] data, byte[] key, byte[] iv)
        {
            using (var aes = Aes.Create())
            {
                aes.KeySize = 128;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.Zeros;

                aes.Key = key;
                aes.IV = iv;

                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                {
                    return PerformCryptography(data, encryptor);
                }
            }
        }

        public byte[] Decrypt(byte[] data, byte[] key, byte[] iv)
        {
            using (var aes = Aes.Create())
            {
                aes.KeySize = 128;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.Zeros;

                aes.Key = key;
                aes.IV = iv;

                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                return PerformCryptography(data, decryptor);
            }
        }

        private byte[] PerformCryptography(byte[] data, ICryptoTransform cryptoTransform)
        {
            using (var ms = new MemoryStream())
            using (var cryptoStream = new CryptoStream(ms, cryptoTransform, CryptoStreamMode.Write))
            {
                cryptoStream.Write(data, 0, data.Length);
                cryptoStream.FlushFinalBlock();

                return ms.ToArray();
            }
        }
    }
}
//Aug 13, 2021
/*
]FOLLQW[.THE.]YELLQW[
[BRICK[>][ROAD]
_INSPE[CT_IN]SPECT_
[CQDE]RS[B]CQDIN
{/\/\}[AGENTS].[ATT]RACT
[N]IGHT{F}IGHT>{BETA}DATA[
[T]IME[LESS]

N.C.S.W.I.C.

John McAfee.
*/
/*
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
*/
//Aug 15, 2021
/*
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
*/