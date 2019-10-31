using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace mntsiwake
{
    class Entity
    {
        public struct KariKashi
        {
            public string Bumon;       //部門コード
            public string Kamoku;      //科目コード
            public string Hojo;        //補助コード
            public string Kin;         //金額
            public string TaxMas;      //消費税計算区分
            public string TaxKbn;      //税区分
        }

        public struct Gyou
        {
            public string GyouNum;          //行番号
            public KariKashi Kari;          //借方データ
            public KariKashi Kashi;         //貸方データ
            public string CopyChk;          //摘要複写チェック
            public string Tekiyou;          //摘要
            public string Torikeshi;        //取消チェック
            public string ProjectCode;      //プロジェクトコード
            public string SubProjectCode;   //サブプロジェクトコード
        }

        public struct Head
        {
            public string image;        //画像ファイル名
            public string CsvFile;      //CSVファイル名  2004/6/24
            public string Year;         //年
            public string Month;        //月
            public string Day;          //日
            public string Kessan;       //決算処理フラグ
            public string FukusuChk;    //複数毎チェック
            public Decimal Kari_T;      //借方合計
            public Decimal Kashi_T;     //貸方合計
            public int FukuMai;         //複数毎数

            public string DenNo;
        }

        public struct InputRecord
        {
            public Head Head;           //ヘッダ部
            public Gyou[] Gyou;         //行データ
            public Decimal KariTotal;       //借方合計
            public Decimal KashiTotal;      //貸方合計
        }

        //出力科目データ
        public struct OutKamokuData
        {
            public string Bumon;            //部門
            public string Kamoku;           //科目
            public string Hojo;             //補助
            public string TaxKbn;           //税区分
            public string TaxMas;           //税率区分
            public string ProjectCode;      //プロジェクトコード
            public string SubProjectCode;   //サブプロジェクトコード
            public string Kin;              //本体金額
        }

        //出力データ
        public struct OutputRecord
        {
            public string Kugiri;       //伝票区切
            public string DenBumon;     //伝票部コード
            public string Date;         //伝票日付
            public string Arrange;      //整理区分  2011/06/07
            public OutKamokuData Kari;  //借方データ
            public OutKamokuData Kashi; //貸方データ
            public string Tekiyou;      //摘要
        }

        //汎用データヘッダ項目
        public class OutPutHeader
        {
            public const string dn01 = @"""OBCD001""";  //伝票区切

            public const string hd01 = @"""CSJS004""";  //伝票部門コード 
            public const string hd02 = @"""CSJS005""";  //日付 
            public const string hd03 = @"""CSJS006""";  //整理区分  2011/06/07
   
            public const string kr01 = @"""CSJS200""";  //借方部門コード
            public const string kr02 = @"""CSJS201""";  //借方勘定科目コード
            public const string kr03 = @"""CSJS202""";  //借方補助科目コード
            public const string kr04 = @"""CSJS203""";  //借方税区分コード
            public const string kr05 = @"""CSJS206""";  //借方消費税計算
            public const string kr06 = @"""CSJS211""";  //借方プロジェクトコード
            public const string kr07 = @"""CSJS212""";  //借方サブプロジェクトコード
            public const string kr08 = @"""CSJS213""";  //借方本体金額

            public const string ks01 = @"""CSJS300""";  //借方部門コード
            public const string ks02 = @"""CSJS301""";  //借方勘定科目コード
            public const string ks03 = @"""CSJS302""";  //借方補助科目コード
            public const string ks04 = @"""CSJS303""";  //借方税区分コード
            public const string ks05 = @"""CSJS306""";  //借方消費税計算
            public const string ks06 = @"""CSJS311""";  //借方プロジェクトコード
            public const string ks07 = @"""CSJS312""";  //借方サブプロジェクトコード
            public const string ks08 = @"""CSJS313""";  //借方本体金額

            public const string tk01 = @"""CSJS100""";  //摘要
        }

    }
}
