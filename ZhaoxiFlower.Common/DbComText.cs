using SqlSugar;
using System.Reflection;
using ZhaoxiFlower.Model.Entitys;

namespace ZhaoxiFlower.Common
{
    public class DbComText
    {
        //通过SQLsugar链接访问数据库
        public static SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
        {
            //数据库链接字符串
            ConnectionString = " Data Source=LAPTOP-KSQ2NMQM; Initial Catalog=ZhaoxiFlowerDb2; " +
            "Integrated Security=SSPI;Encrypt=True;TrustServerCertificate=True; User Id=sa; Password=123456;",
            //数据库类型
            DbType = DbType.SqlServer,
            //是否自动关闭链接
            IsAutoCloseConnection = true//不设置为true要手动关闭
        });
        public static void InitDataBase()
        {
            //初始化数据库:如果不存在则创建数据库
            db.DbMaintenance.CreateDatabase();
            //创建表（先定义模型，再根据模型创建表）
            string nspace = "ZhaoxiFlower.Model.Entitys";
            Type[] ass = Assembly.LoadFrom("D:\\桌面\\WebApi Bibilili\\WebApi\\bin\\Debug\\net6.0\\ZhaoxiFlower.Model.dll")
                .GetTypes().Where(p => p.Namespace == nspace).ToArray(); //Assembly.LoadFrom反射
            db.CodeFirst.SetStringDefaultLength(200).InitTables(ass);
            //模拟测试数据
            List<Flowers> flowers = new List<Flowers>() {
                #region 爱情鲜花
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/a1.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=200
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=1 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/a2.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=201
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=1 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/a3.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=202
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=1 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/a4.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=203
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=1 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/a5.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=204
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=1 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/a6.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=205
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=1 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/a7.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=206
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=1 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/a8.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=207
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=1 },
	            #endregion
                #region 生日鲜花
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/s1.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=300
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=2 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/s2.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=301
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=2 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/s3.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=302
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=2 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/s4.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=303
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=2 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/s5.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=304
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=2 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/s6.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=305
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=2 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/s7.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=306
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=2 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/s8.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=307
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=2 },
	            #endregion
                #region 友情鲜花
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/y1.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=100
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=3 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/y2.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=101
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=3 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/y3.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=102
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=3 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/y4.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=103
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=3 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/y5.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=104
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=3 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/y6.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=105
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=3 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/y7.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=106
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=3 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/y8.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=107
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=3 },
	            #endregion
                #region 婚庆鲜花
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/a1.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=500
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=4 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/s1.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=501
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=4 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/y1.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=502
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=4 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/a2.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=503
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=4 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/s2.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=504
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=4 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/y2.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=505
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=4 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/a3.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=506
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=4 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/s3.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=507
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=4 },
	            #endregion
            };


            List<FileCards> fileCards = new List<FileCards>()
            {
                new FileCards(){
                    Id= 1,
                    Title= "长津湖",
                    SubTitle= "抗美援朝经典之战",
                    BottomLabel= "",
                    pic= "https://m.ykimg.com/0584000061A868231FD852098F9700D0?x-oss-process=image/resize,w_290/interlace,1/quality,Q_80"
                },
                new FileCards(){
                    Id= 2,
                    Title= "门锁",
                    SubTitle= "白百何诠释独居女",
                    BottomLabel= "",
                    pic= "https://m.ykimg.com/0584000061C567B913F7FF09582A36A3?x-oss-process=image/resize,w_290/interlace,1/quality,Q_80"
                },
                new FileCards()
                {
                    Id= 3,
                    Title= "铁道英雄",
                    SubTitle= "铁道英雄热血抗战",
                    BottomLabel= "",
                    pic= "https://m.ykimg.com/0584000061D00101202742096F393ABB?x-oss-process=image/resize,w_290/interlace,1/quality,Q_80"
                },
                new FileCards()
                {
                    Id= 4,
                    Title= "再战江湖",
                    SubTitle= "陈小春肉搏黑帮",
                    BottomLabel= "",
                    pic= "https://m.ykimg.com/0527000061BC409520274208DAE3909E?x-oss-process=image/resize,w_290/interlace,1/quality,Q_80"
                },
                new FileCards()
                {
                     Id= 5,
        Title= "扫毒2天地对决",
        SubTitle= "华仔古仔双雄争锋",
         BottomLabel= "",
        pic= "https://m.ykimg.com/058400005F1EBF374265930D3F704B41?x-oss-process=image/resize,w_290/interlace,1/quality,Q_80"

                },
                new FileCards()
                {
                     Id= 6,
        Title= "二龙湖往事：惊魂夜",
        SubTitle= "东北农村离奇诡事",
         BottomLabel= "",
        pic= "https://m.ykimg.com/0527000061B0646D13F7FF0951E5C6AD?x-oss-process=image/resize,w_290/interlace,1/quality,Q_80"
                },
                new FileCards()
                {
                Id= 7,
        Title= "1950他们正年轻",
        SubTitle= "致敬抗美援朝英雄",
         BottomLabel= "",
        pic= "https://m.ykimg.com/0584000061C564C313EB660A46DB5B33?x-oss-process=image/resize,w_290/interlace,1/quality,Q_80"
                },
                new FileCards()
                {
                    Id= 8,
        Title= "反贪风暴4",
        SubTitle= "古仔闯牢狠打虎",
         BottomLabel= "",
        pic= "https://m.ykimg.com/058400006047253913EA350855339545?x-oss-process=image/resize,w_290/interlace,1/quality,Q_80"

                },
                new FileCards()
                {
                Id= 9,
        Title= "请叫我总监",
        SubTitle= "职场邂逅欢乐甜怼",
       BottomLabel= "32 集全",
        pic= "https://m.ykimg.com/05840000616FACD013F7FF098083A771?x-oss-process=image/resize,w_290/interlace,1/quality,Q_80"

                },
                new FileCards()
                {
                Id= 10,
        Title= "良辰好景知几何",
        SubTitle= "将军爱上清冷才女",
         BottomLabel= "",
        pic= "https://m.ykimg.com/05840000626514521FD85209207E984E?x-oss-process=image/resize,w_290/interlace,1/quality,Q_80"

                },
                new FileCards()
                {
                     Id= 11,
        Title= "怦然心动20岁 第二季",
        SubTitle= "毕业之旅甜蜜回归",
        BottomLabel= "更新至06-05期",
        pic= "https://m.ykimg.com/0584000062980D9713EB660937D7BF75?x-oss-process=image/resize,w_290/interlace,1/quality,Q_80"

                },
                    new FileCards()
                    {
                        Id= 12,
        Title= "了不起！舞社",
        SubTitle= "毕业之旅甜蜜回归",
        BottomLabel= "更新至06-12期",
        pic= "https://m.ykimg.com/058400006258C3D913EB66114B215112?x-oss-process=image/resize,w_290/interlace,1/quality,Q_80"

                    }
            };
            //写入测试数据        
            db.Insertable(flowers).ExecuteCommand();
            db.Insertable(fileCards).ExecuteCommand();

        }
    }
}