-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jul 11, 2020 at 09:27 AM
-- Server version: 10.4.10-MariaDB
-- PHP Version: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `poemonline`
--
CREATE DATABASE IF NOT EXISTS `poemonline` DEFAULT CHARACTER SET utf8 COLLATE utf8_persian_ci;
USE `poemonline`;

-- --------------------------------------------------------

--
-- Table structure for table `author`
--

DROP TABLE IF EXISTS `author`;
CREATE TABLE IF NOT EXISTS `author` (
  `ID` int(11) NOT NULL,
  `Name` mediumtext COLLATE utf8_persian_ci NOT NULL,
  `Age` mediumtext COLLATE utf8_persian_ci NOT NULL,
  `About` text COLLATE utf8_persian_ci NOT NULL,
  `img` mediumtext COLLATE utf8_persian_ci NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `author`
--

INSERT INTO `author` (`ID`, `Name`, `Age`, `About`, `img`) VALUES
(201, 'اميلی برونته', 'N/A', 'امیلی جین برونته (به انگلیسی: Emily Jane Brontë) (زاده ۱۸۱۸ در ثورتن یورک‌شر – درگذشته ۱۸۴۸ در هاورث یورک‌شر) داستان نویس و شاعر بریتانیایی است. رمان بلندی‌های بادگیر او اثر بسیار معروفی است. به نظر بعضی از منتقدان ادبی شخصیت کتی بسیار شبیه خود امیلی و شاید هیت کلیف نمایندهٔ آن دسته از مردانی باشد که امیلی قادر به دوست داشتن آن‌ها بود. کتاب بلندی‌های بادگیر (یا عشق هرگز نمی‌میرد) شهرتی جهانی یافته‌است. امیلی برونته اشعار بسیاری نیز سروده‌است. برخی از اشعار او به همراه اشعار دو خواهر دیگرش، شارلوت برونته و آن برونته در یک مجموعه به چاپ رسید.[۱]', './backend-assets/201'),
(200, 'اميلی ديکنسون', 'N/A', 'امیلی الیزابت دیکینسون (به انگلیسی: Emily Elizabeth Dickinson) شاعر آمریکایی (۱۰ دسامبر ۱۸۳۰–۱۵می ۱۸۸۶) در شهر امهرست در ایالت ماساچوست آمریکا و در یک خانوادهٔ متشخص و اصیل به دنیا آمد، او بیشتر خلوت گزیده بود و زندگی در انزوا را ترجیح می‌داد. در دوران جوانی به مدت ۷ سال در آکادمی امهرست درس خواند و قبل از بازگشتش به شهر خود، مدت کوتاهی را نیز در یک مدرسه مذهبی گذراند. او به‌خاطر پوشیدن لباس سفید و عدم استقبال از مهمان در بین ساکنین معروف گشت، و بیشتر دوستی‌هایش از طریق نامه و مکاتبه بود. اگرچه او شاعر پرکاری بود ولی تعداد کمی از شعرهایش (نزدیک به ۱۸۰۰عدد) به چاپ رسید.[۱] آثاری که در زمان حیاتش به چاپ رسید دچار تغییر می‌گشتند تا با معیارهای متعارف شعری وقت مطابق شوند. شعرهای دیکینسون در زمان خود منحصربه‌فرد بودند، زیرا دارای خطوط کوتاه، عدم وجود عنوان در شعر و از قافیهٔ کج یا نیم‌قافیه برخوردار بودند که چیزی غیرمتعارف بود.[۲] بسیاری از شعرهای او درون‌مایهٔ مرگ و جاودانگی داشتند، که در نامه‌هایش نیز مشهود بود.', './backend-assets/200'),
(202, 'حکیم عمر خیام', 'N/A', 'عُمَر خَیّام نیشابوری (نام کامل: غیاث‌الدین ابوالفتح عُمَر بن ابراهیم خَیّام نیشابوری) (زادهٔ ۲۸ اردیبهشت ۴۲۷ خورشیدی (۴۳۹ ق) در نیشابور – درگذشتهٔ ۱۲ آذر ۵۱۰ خورشیدی در نیشابور)[۳] که خیامی، خیام نیشابوری و خیامی النّیسابوری[۲] هم نامیده شده‌است، همه‌چیزدان،[۴][۵] فیلسوف، ریاضی‌دان، ستاره‌شناس و شاعر رباعی‌سرای ایرانی در دورهٔ سلجوقی است. گرچه پایگاه علمی خیام برتر از جایگاه ادبی اوست و لقبش «حجّةالحق» بوده‌است،[۶] ولی آوازهٔ وی مدیون نگارش رباعیاتش است که شهرت جهانی دارد. با وجود آنکه رباعیات خیام به بیشترِ زبان‌های زنده برگردان شده، آوازهٔ وی در غرب بیشتر مدیون ترجمهٔ رباعیات او توسط ادوارد فیتزجرالد[۷] به زبان انگلیسی است.\r\n\r\nیکی از برجسته‌ترین کارهای وی را می‌توان سروسامان دادن و سرپرستی محاسبات گاه‌شماری ایران در زمان وزارت خواجه نظام‌الملک، که در دورهٔ پادشاهی ملک‌شاه سلجوقی (۴۲۶–۴۹۰ هجری قمری) بود، دانست؛ محاسبات منسوب به خیام در این زمینه، هنوز معتبر است و دقتی به مراتب بالاتر از گاه‌شماری میلادی دارد. وی در ریاضیات، نجوم، علوم ادبی، دینی و تاریخی استاد بود. نقش خیام در حل معادلات درجهٔ سوم و مطالعاتش دربارهٔ اصل پنجم اقلیدس نام او را بعنوان ریاضی‌دانی برجسته در تاریخ علم ثبت کرده است.[۸] نوپیدا کردن نظریه‌ای دربارهٔ نسبت‌های هم‌ارز با نظریهٔ اقلیدس نیز از مهمترین کارهای اوست.[۹]\r\n\r\nشماری از تذکره‌نویسان، خیام را شاگرد ابن‌سینا و شماری نیز وی را شاگرد امام موفق نیشابوری خوانده‌اند.[۶][۱۰][۱۱] صحت این فرضیه که خیام شاگرد ابن‌سینا بوده است، بسیار دور از ذهن می‌نماید، زیرا از دیدِ زمانی با هم دگرگونیِ زیادی داشته‌اند. خیام در جایی ابن‌سینا را استاد خود می‌داند، ولی این استادی ابن‌سینا، جنبهٔ معنوی دارد.\r\n\r\n', './backend-assets/202'),
(203, 'فردریک بکمن', '39', 'کارل فردریک بکمن (Carl Fredrik Backman) نویسنده و وبلاگ‌نویس سوئدی‌ست که در دوم ژانویه ۱۹۸۱ در استکهلم به دنیا آمده است. پیش‌ترها شهرت بکمن در سوئد به‌خاطر وبلاگ‌نویسی بود. او برای روزنامه‌های مختلف مقاله می‌نوشت و همکاری‌اش را با مجله مترو هم شروع کرد. همین‌طور در سال ۲۰۱۲ کتاب مردی به نام اوه را نوشت که همان سال بیش از ۶۰۰ هزار نسخه از آن فروش رفت. این کتاب در حال حاضر به بیش از ۳۰ زبان ترجمه شده، رتبه اول پرفروش‌های سوئد و نیویورک تایمز را از آن خود کرده و فیلم برگرفته از کتاب با همین نام در ۲۰۱۶ در سینماهای جهان اکران شد. ترجمه فارسی رمان مردی به نام اوه توسط نشرنون، تندیس و چشمه منتشرشده‌است که در ایران نیز با استقبال زیادی روبرو شده‌است. او با همسر ایرانی خود دو فرزندش ساکن سوئد است .[۱]\r\n\r\nاثر دیگر این نویسنده؛ بریت ماری اینجا بود که در سال ۲۰۱۶ چاپ شده، توسط نشرنون و با ترجمه فرناز تیمورازف منتشر شده‌است.[۲]', './backend-assets/203');

-- --------------------------------------------------------

--
-- Table structure for table `book`
--

DROP TABLE IF EXISTS `book`;
CREATE TABLE IF NOT EXISTS `book` (
  `ID` int(11) NOT NULL,
  `Title` mediumtext COLLATE utf8_persian_ci NOT NULL,
  `Author` mediumtext COLLATE utf8_persian_ci NOT NULL,
  `Description` mediumtext COLLATE utf8_persian_ci NOT NULL,
  `cover` mediumtext COLLATE utf8_persian_ci NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `book`
--

INSERT INTO `book` (`ID`, `Title`, `Author`, `Description`, `cover`) VALUES
(100, 'من پیش از تو', 'جوجو مویز', 'من پیش از تو\r\nرمان عاشقانه من پیش از تو نوشته جوجو مویز را با ترجمه مریم مفتاحی به صورت الکترونیکی خریدم. بر این قصد بودم که بتوانم هر شب قبل از خواب بخشی از آن را بخوانم. شروع کردم، در گوشه‌ای از اتاق در سکوتی جاودانه داستان عاشقانه بین لوئیزا کلارک و ویل ترینر را از طریق تبلت می‌خواندم. آنقدر با کتاب اُنس یافته بودم که احساس می‌کردم از زندگی‌ام الهام گرفته شده است. هر شبم آکنده از غم، شادی، اشک و خنده بود، بی‌آنکه بدانم در کجایم، در داستان غرق شده بودم. هر لحظه بخش از رمان انگار تداعی بخش خاطره‌ای دور و تجربه‌ای نزدیک بود. مواقعی بعد از خواندن رمان من پیش از تو، افسردگی وجودم را می‌گرفت و زمانی از حس عاشقانه لبریزم می‌کرد. وقتی آخرین صفحات کتاب را خواندم و پایان داستان را فهمیدم، پیش از پیش به زندگی‌ام بالیدم؛ به ناگهان از جایم برخاستم و شتابان به اتاق همسرم رفتم و او را که بر روی ویلچرش نشسته بود، بوسه باران کردم. سپس همسرم رو به من کرد و گفت: «من فقط می‌خواهم مردی باشم که دختری با لباس قرمز در کنارم و در کنسرت موسیقی زنده نشسته‌ است؛ فقط برای چند دقیقه بیشتر.»', './backend-assets/100'),
(101, 'بریت‌ماری اینجا بود', 'فردریک بکمن', 'افراد زیادی در جامعه هستند که سن خود را برای اهمال کاری و به تعویق انداختن کارها بهانه می‌کنند. فرقی نمی‌کند در چند سالگی، همیشه عده‌ای هستند که می‌گویند: «از من گذشته است» یا «دیگر برای این کارها دیر شده است» اما با نگاه به زندگی بعضی از افراد می‌توان به این درک رسید که هیچ‌گاه برای شروع دیر نیست. «بریت ماری» در کتاب «بریت ماری اینجا بود» زنی است که در آستانه‌ی 70 سالگی به دنبال رویاهای خود می‌رود و تسلیم نمی‌شود. خواندن داستان زندگی او امید و انگیزه را در دل زندگی می‌کند.', './backend-assets/101'),
(102, 'مجموعه اشعار خیام', 'حکیم عمر خیام', 'دنیا دیدی و هرچه دیدی هیچ است، و آن نیز که گفتی و شنیدی هیچ است، سرتاسرِ آفاق دویدی هیچ است، و آن نیز که در خانه خزیدی هیچ است.', './backend-assets/102'),
(103, 'زنان عاشق', 'اليزابت بارت ، اميلی برونته ، اميلی ديکنسون', 'آه تو ای رز! چه کسی جرات چنین نامیدن تو را دارد؟ نه دیگر رنگ و رخی دارم و نه لطافتی رنگ پریده ای و خشک همچو خوشه ای گندم، هفت ساله، در کنج انبار القابت مایه شرمساری‌ات باشند نسیمی که از میان خارها، بر تو می‌وزید و عطر تو را تمام روز در کوچه‌ها می‌افشاند اگر اکنون بر تو بوزد مایه نابودی‌ات شود خورشیدی که بر تو می‌تابید و شکوه خود را در گلدان زیبای تو می‌آمیخت تا انوارش شکوفه زنند و غنچه زیبا را بیدار کند اگر اکنون بتابد بدون قیل و دادی جان‌ات را می‌گیرد شبنمی که به تو لطافت می‌بخشید و از سرخی رخ تو گلگون می‌گشت اگر اکنون بر تو نازل شود مایه تاریکی میعادگاهتان باشد آن مگس که بر فرازت پرواز میکرد تا پاهای ظریف اش را بر گلبرگ های پاک تو بیارامد اگر اکنون به پرواز در آید بر تو هجوم آورد آن زنبور که از شیره تو می‌مکید و هستی خوشبوی تو را به کندو خویش می‌برد و در لذت با تو بودن سر مست می‌شد اگر اکنون گذرش بر تو افتد نگاهی هم نثارت نخواهد کرد اما آن قلب، آن قلب تو را شناخت تنهای تنها، و چه شیرین تو را بوئید تو را در اوج زیبایی دید', './backend-assets/103');

-- --------------------------------------------------------

--
-- Table structure for table `poem`
--

DROP TABLE IF EXISTS `poem`;
CREATE TABLE IF NOT EXISTS `poem` (
  `ID` int(11) NOT NULL,
  `Title` mediumtext COLLATE utf8_persian_ci NOT NULL,
  `Author` mediumtext COLLATE utf8_persian_ci NOT NULL,
  `Poem` mediumtext COLLATE utf8_persian_ci NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `poem`
--

INSERT INTO `poem` (`ID`, `Title`, `Author`, `Poem`) VALUES
(300, 'قصیدهٔ شمارهٔ ۸', 'پروین اعتصامی', 'ای عجب! این راه نه راه خداست\r\n.\r\nزانکه در آن اهرمنی رهنماست\\r\\n\r\n\r\nقافله بس رفت از این راه، لیک\r\n.\r\nکس نشد آگاه که مقصد کجاست\\r\\n\r\n\r\nراهروانی که درین معبرند\r\n.\r\nفکرتشان یکسره آز و هواست\\r\\n\r\n\r\nای رمه، این دره چراگاه نیست\r\n.\r\nای بره، این گرگ بسی ناشتاست\\r\\n\r\n\r\nتا تو ز بیغوله گذر میکنی\r\n.\r\nرهزن طرار تو را در قفاست\\r\\n\r\n\r\nدیده ببندی و درافتی بچاه\r\n.\r\nاین گنه تست، نه حکم قضاست\\r\\n\r\n\r\nلقمهٔ سالوس کرا سیر کرد\r\n.\r\nچند بر این لقمه تو را اشتهاست\\r\\n\r\n\r\nنفس، بسی وام گرفت و نداد\r\n.\r\nوام تو چون باز دهد؟ بینواست\\r\\n\r\n\r\nخانهٔ جان هرچه توانی بساز\r\n.\r\nهرچه توان ساخت درین یک بناست\\r\\n\r\n\r\nکعبهٔ دل مسکن شیطان مکن\r\n.\r\nپاک کن این خانه که جای خداست\\r\\n\r\n\r\nپیرو دیوانه شدن ز ابلهی است\r\n.\r\nموعظت دیو شنیدن خطاست\\r\\n\r\n\r\nتا بودت شمع حقیقت بدست\r\n.\r\nراه تو هرجا که روی روشناست\\r\\n\r\n\r\nتا تو قفس سازی و شکر خری\r\n.\r\nطوطیک وقت ز دامت رهاست\\r\\n\r\n\r\nحمله نیارد بتو ثعبان دهر\r\n.\r\nتا چو کلیمی تو و دینت عصاست\\r\\n\r\n\r\nای گل نوزاد فسرده مباش\r\n.\r\nزانکه تو را اول نشو و نماست\\r\\n\r\n\r\nطائر جانرا چه کنی لاشخوار\r\n.\r\nنزد کلاغش چه نشانی؟ هماست\\r\\n\r\n\r\nکاهلیت خسته و رنجور کرد\r\n.\r\nدرد تو دردیست که کارش دواست\\r\\n\r\n\r\nچاره کن آزردگی آز را\r\n.\r\nتا که بدکان عمل مومیاست\\r\\n\r\n\r\nروی و ریا را مکن آئین خویش\r\n.\r\nهرچه فساد است ز روی و ریاست\\r\\n\r\n\r\nشوخ‌تن و جامه چه شوئی همی\r\n.\r\nاین دل آلوده به کارت گواست\\r\\n\r\n\r\nپای تو همواره براه کج است\r\n.\r\nدست تو هر شام و سحر بر دعاست\\r\\n\r\n\r\nچشم تو بر دفتر تحقیق، لیک\r\n.\r\nگوش تو بر بیهده و ناسزاست\\r\\n\r\n\r\nبار خود از دوش برافکنده‌ای\r\n.\r\nپشت تو از پشتهٔ شیطان دوتاست\\r\\n\r\n\r\nنان تو گه سنگ بود گاه خاک\r\n.\r\nتا به تنور تو هوی نانواست\\r\\n\r\n\r\nورطه و سیلاب نداری به پیش\r\n.\r\nتا خردت کشتی و جان ناخداست\\r\\n\r\n\r\nقصر دل‌افروز روان محکم است\r\n.\r\nکلبهٔ تن را چه ثبات و بقاست\\r\\n\r\n\r\nجان بتو هرچند دهد منعم است\r\n.\r\nتن ز تو هرچند ستاند گداست\\r\\n\r\n\r\nروغن قندیل تو آبست و بس\r\n.\r\nتیرگی بزم تو بیش از ضیاست\\r\\n\r\n\r\nمنزل غولان ز چه شد منزلت\r\n.\r\nگر ره تو از ره ایشان جداست\\r\\n\r\n\r\nجهل بلندی نپسندد، چه است\r\n.\r\nعجب سلامت نپذیرد، بلاست\\r\\n\r\n\r\nآنچه که دوران نخرد یکدلیست\r\n.\r\nآنچه که ایام ندارد وفاست\\r\\n\r\n\r\nدزد شد این شحنهٔ بی نام و ننگ\r\n.\r\nدزد کی از دزد کند بازخواست\\r\\n\r\n\r\nنزد تو چون سرد شود؟ آتش است\r\n.\r\nاز تو چرا درگذرد؟ اژدهاست\\r\\n\r\n\r\nوقت گرانمایه و عمر عزیز\r\n.\r\nطعمهٔ سال و مه و صبح و مساست\\r\\n\r\n\r\nاز چه همی کاهدمان روز و شب\r\n.\r\nگر که نه ما گندم و چرخ آسیاست\\r\\n\r\n\r\nگر که یمی هست، در آخر نمی‌است\r\n.\r\nگر که بنائی است، در آخر هباست\\r\\n\r\n\r\nما بره آز و هوی سائلیم\r\n.\r\nمورچه در خانهٔ خود پادشاست\\r\\n\r\n\r\nخیمه ز دستیم و گه رفتن است\r\n.\r\nغرق شدستیم و زمان شناست\\r\\n\r\n\r\nگلبن معنی نتوانی نشاند\r\n.\r\nتا که درین باغچه خار و گیاست\\r\\n\r\n\r\nکشور جان تو چو ویرانه‌ایست\r\n.\r\nملک دلت چون ده بی روستاست\\r\\n\r\n\r\nشعر من آینهٔ کردار تست\r\n.\r\nناید از آئینه به جز حرف راست\\r\\n\r\n\r\nروشنی اندوز که دلرا خوشی است\r\n.\r\nمعرفت آموز که جانرا غذاست\\r\\n\r\n\r\nپایهٔ قصر هنر و فضل را\r\n.\r\nعقل نداند ز کجا ابتداست\\r\\n\r\n\r\nپردهٔ الوان هوی را بدر\r\n.\r\nتا بپس پرده ببینی چهاست\\r\\n\r\n\r\nبه که بجوی و جر دانش چرد\r\n.\r\nآهوی جانست که اندر چراست\\r\\n\r\n\r\nخیره ز هر پویه ز میدان مرو\r\n.\r\nبا فلک پیر ترا کارهاست\\r\\n\r\n\r\nاطلس نساج هوی و هوس\r\n.\r\nچون گه تحقیق رسد بوریاست\\r\\n\r\n\r\nبیهده، پروین در دانش مزن\r\n.\r\nبا تو درین خانه چه کس آشناست\\r\\n'),
(301, 'غزل شمارهٔ ۲', 'حافظ', 'صلاح کار کجا و من خراب کجا\r\n.\r\nببین تفاوت ره کز کجاست تا به کجا\\r\\n\r\n\r\nدلم ز صومعه بگرفت و خرقه سالوس\r\n.\r\nکجاست دیر مغان و شراب ناب کجا\\r\\n\r\n\r\nچه نسبت است به رندی صلاح و تقوا را\r\n.\r\nسماع وعظ کجا نغمه رباب کجا\\r\\n\r\n\r\nز روی دوست دل دشمنان چه دریابد\r\n.\r\nچراغ مرده کجا شمع آفتاب کجا\\r\\n\r\n\r\nچو کحل بینش ما خاک آستان شماست\r\n.\r\nکجا رویم بفرما از این جناب کجا\\r\\n\r\n\r\nمبین به سیب زنخدان که چاه در راه است\r\n.\r\nکجا همی‌روی ای دل بدین شتاب کجا\\r\\n\r\n\r\nبشد که یاد خوشش باد روزگار وصال\r\n.\r\nخود آن کرشمه کجا رفت و آن عتاب کجا\\r\\n\r\n\r\nقرار و خواب ز حافظ طمع مدار ای دوست\r\n.\r\nقرار چیست صبوری کدام و خواب کجا\\r\\n'),
(302, 'غزل شمارهٔ ۶', 'خواجوی کرمانی', 'بگذر ای خواجه و بگذار مرا مست اینجا\r\n.\r\nکه برون شد دل سرمست من از دست اینجا\\r\\n\r\n\r\nچون توانم شد از اینجا که غمش موی کشان\r\n.\r\nدلم آورد و به زنجیر فرو بست اینجا\\r\\n\r\n\r\nتا نگوئی که من اینجا ز چه مست افتادم\r\n.\r\nهیچ هشیار نیامد که نشد مست اینجا\\r\\n\r\n\r\nکیست این فتنهٔ نوخاسته کز مهر رخش\r\n.\r\nاین دل شیفته حال آمد و بنشست اینجا\\r\\n\r\n\r\nدل مسکین مرا نیست در اینجا قدری\r\n.\r\nزانک صد دل چو دل خسته من هست اینجا\\r\\n\r\n\r\nدوش کز ساغر دل خون جگر میخوردم\r\n.\r\nشیشه نا گه بشد از دستم و بشکست اینجا\\r\\n\r\n\r\nنام خواجو مبر ای خواجه درین ورطه که هست\r\n.\r\nصد چو آن خستهٔ دلسوخته در شست اینجا\\r\\n'),
(303, 'رباعی شمارهٔ ۱۱', 'خیام', 'ای آمده از عالم روحانی تفت\r\n.\r\nحیران شده در پنج و چهار و شش و هفت\\r\\n\r\n\r\nمی نوش ندانی ز کجا آمده‌ای\r\n.\r\nخوش باش ندانی به کجا خواهی رفت\\r\\n');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;