let puppeteer = require('puppeteer')
require('dotenv').config({path: 'mysql/.env'})
const wait = (timeToDelay) => new Promise((resolve) => setTimeout(resolve, timeToDelay))
const mysql = require('./mysql')
const express = require("express");

const app = express();
app.use(express.json());
app.use(express.urlencoded({extended: true}));

app.use(express.static('public'));  //파일을 넣을 수 있습니다.  
app.use('/static', express.static('public'));  



app.set('view engine', 'ejs')

app.use(express.json({
    limit: '50mb'
}))


app.listen(3000, () => {
    console.log("Server Started port 3000...")
});

app.get('/result',  async(req, res) => {  
    const news = await mysql.query('newsList');
    var i;
    const obj = [];

    for(i = 0; i < news.length; i++){
        obj[i] ={
        Num : news[i].Num,
        Title : news[i].Title,
        Link: news[i].Link
    }
    }
    res.render('index', {data:obj});
    
 })  


 async function parse()
{
  // 페이지 보안설정
  let browser = await puppeteer.launch({args: [
    "--disable-web-security",
    "--disable-features=IsolateOrigins,site-per-process",
   "--disable-infobars"
  ], });

//메인 페이지 오픈
const page = await browser.newPage();
await page.goto( "https://www.kprc.or.kr/RawMaterial.do?lcla_cd=0100&mcla_cd=50&page=1&page_sz=10&board_id=raw01&itemst_cd=0100&item_cd=0010&to_yyyymm=&from_yyyymm=&board=0#con01" );

//현재 가격 현황 크롤링
let ehList = await page.$$("#PriceResult > tr");
console.log(ehList);
for(let eh of ehList){
    var i = 0;
    let Name  = await eh.$eval('td.text-left', function(el){
        return el.innerText
    })
    let Unit  = await eh.$eval('td:nth-child(2)', function(el){
        return el.innerText
    })
    let Price = await eh.$eval('td.text-right.color-red', function(el){
        return el.innerText
    })
    let Ratio_mon = await eh.$eval('td:nth-child(4)', function(el){
        return el.innerText
    })
    let Ratio_year = await eh.$eval('td:nth-child(5) > span', function(el){
        return el.innerText
    })
    let Source = await eh.$eval('td:nth-child(6) > span', function(el){
        return el.innerText
    })
    obj = {
        name : Name,
        unit : Unit,
        price : Price,
        ratio_mon : Ratio_mon,
        ratio_year : Ratio_year,
        source : Source
    }
    console.log(obj);
    await mysql.query('customerInsert', obj);
}

//클릭명령 정의 및 실행 '2021'월 클릭
const selector = (await page.$x(
    "//select[@name='to_yyyy']"
 ))[0];
const id = await (await selector.getProperty('id')).jsonValue();
await page.select('#' + id, '2021'); 

//클릭명령 정의 및 실행 '9'월 클릭
const selector1 = (await page.$x(
    "//select[@name='to_mm']"
 ))[0];
const id1 = await (await selector1.getProperty('id')).jsonValue();
await page.select('#' + id1, '9'); 
// 검색버튼 클릭
await page.$eval( '#con01 > div.detail-search > dl > dd > div > div.right > button', form => form.click() );
// 세션로드를 불러오는 시간을 벌기 위하 대기 시간 부여
await wait(2000)
//알루미늄 데이터 파일 크롤링 및 mysql전송
let ehList_a = await page.$$("#livingPriceResult > tr");
console.log(ehList_a);
for(let eh of ehList_a){
    var i = 0;
    let Date  = await eh.$eval('td', function(el){
        return el.innerText
    })
    let Price  = await eh.$eval('td.text-right.color-red', function(el){
        return el.innerText
    })
    obj = {
        date : Date,
        price : Price
    }
  
    await mysql.query('customerInsert_a',obj);
}
//납 데이터 파일 크롤링을 위한 페이지 이동 및 기간설정
await page.goto("https://www.kprc.or.kr/RawMaterial.do?lcla_cd=0100&mcla_cd=50&page=1&page_sz=10&board_id=raw01&itemst_cd=0100&item_cd=0020&to_yyyymm=&from_yyyymm=&board=0#con01")
await page.select('#' + id, '2021'); 
await page.select('#' + id1, '9'); 

await page.$eval( '#con01 > div.detail-search > dl > dd > div > div.right > button', form => form.click() );
await wait(2000)

//납 데이터 파일 크롤링 및 mysql전송
let ehList_l = await page.$$("#livingPriceResult > tr");
console.log(ehList_l);
for(let eh of ehList_l){
    let Date  = await eh.$eval('td', function(el){
        return el.innerText
    })
    let Price  = await eh.$eval('td.text-right.color-red', function(el){
        return el.innerText
    })
    obj = {
        date : Date,
        price : Price
    }

    await mysql.query('customerInsert_l', obj);
}

//아연 데이터 파일 크롤링을 위한 페이지 이동 및 기간설정
await page.goto("https://www.kprc.or.kr/RawMaterial.do?lcla_cd=0100&mcla_cd=50&page=1&page_sz=10&board_id=raw01&itemst_cd=0100&item_cd=0030&to_yyyymm=&from_yyyymm=&board=0#con01")
await page.select('#' + id, '2021'); 
await page.select('#' + id1, '9'); 

// 아연 데이터 파일 크롤링 및 mysql 전송
await page.$eval( '#con01 > div.detail-search > dl > dd > div > div.right > button', form => form.click() );
await wait(2000)
let ehList_z = await page.$$("#livingPriceResult > tr");
console.log(ehList_z);
for(let eh of ehList_z){
    let Date  = await eh.$eval('td', function(el){
        return el.innerText
    })
    let Price  = await eh.$eval('td.text-right.color-red', function(el){
        return el.innerText
    })
    obj = {
        date : Date,
        price : Price
    }
  
    await mysql.query('customerInsert_z', obj);
}


//구리 페이지 이동
await page.goto("https://www.kprc.or.kr/RawMaterial.do?lcla_cd=0100&mcla_cd=50&page=1&page_sz=10&board_id=raw01&itemst_cd=0100&item_cd=0040&to_yyyymm=&from_yyyymm=&board=0#con01")
await page.select('#' + id, '2021'); 
await page.select('#' + id1, '9'); 
// 구리 데이터 파일 크롤링 및 mysql전송
await page.$eval( '#con01 > div.detail-search > dl > dd > div > div.right > button', form => form.click() );
await wait(2000)
let ehList_c = await page.$$("#livingPriceResult > tr");
console.log(ehList_c);
for(let eh of ehList_c){
    let Date  = await eh.$eval('td', function(el){
        return el.innerText
    })
    let Price  = await eh.$eval('td.text-right.color-red', function(el){
        return el.innerText
    })
    obj = {
        date : Date,
        price : Price
    }
  
    await mysql.query('customerInsert_c', obj);
}

//주석페이지 이동
await page.goto("https://www.kprc.or.kr/RawMaterial.do?lcla_cd=0100&mcla_cd=50&page=1&page_sz=10&board_id=raw01&itemst_cd=0100&item_cd=0050&to_yyyymm=&from_yyyymm=&board=0#con01")
await page.select('#' + id, '2021'); 
await page.select('#' + id1, '9'); 
//주석 데이터 크롤링 및 mysql 적용
await page.$eval( '#con01 > div.detail-search > dl > dd > div > div.right > button', form => form.click() );
await wait(2000)
let ehList_t = await page.$$("#livingPriceResult > tr");
console.log(ehList_t);
for(let eh of ehList_t){
    let Date  = await eh.$eval('td', function(el){
        return el.innerText
    })
    let Price  = await eh.$eval('td.text-right.color-red', function(el){
        return el.innerText
    })
    obj = {
        date : Date,
        price : Price
    }

    await mysql.query('customerInsert_t',obj);
}

//니켈 페이지 이동
await page.goto("https://www.kprc.or.kr/RawMaterial.do?lcla_cd=0100&mcla_cd=50&page=1&page_sz=10&board_id=raw01&itemst_cd=0100&item_cd=0060&to_yyyymm=&from_yyyymm=&board=0#con01")
await page.select('#' + id, '2021'); 
await page.select('#' + id1, '9'); 
//니켈 데이터 크롤링 및 mysql 적용
await page.$eval( '#con01 > div.detail-search > dl > dd > div > div.right > button', form => form.click() );
await wait(2000)
let ehList_n = await page.$$("#livingPriceResult > tr");
console.log(ehList_n);
for(let eh of ehList_n){
    let Date  = await eh.$eval('td', function(el){
        return el.innerText
    })
    let Price  = await eh.$eval('td.text-right.color-red', function(el){
        return el.innerText
    })
    obj = {
        date : Date,
        price : Price
    }

    await mysql.query('customerInsert_n', obj);
}

}
parse();
//뉴스파스
async function parse1()
{
    await mysql.query('truncate');
    let browser = await puppeteer.launch({headless: false});
    let page = await browser.newPage();
    page.setViewport({
        width: 1920,
        height: 1080
    });

    await page.goto('https://www.google.com/search?q=%EB%B9%84%EC%B2%A0%EA%B8%88%EC%86%8D&rlz=1C1CAFC_enKR950KR982&sxsrf=ALiCzsbqyG3ZlmEhlzjd9AHrQPawEiF7xw:1663747485773&source=lnms&tbm=nws&sa=X&ved=2ahUKEwjKrIqvtqX6AhVLB94KHYWyDvwQ_AUoAXoECAEQAw&biw=1931&bih=996&dpr=0.9');

    var Title = []
    var Link = []

    let ehList = await page.$$('div.iRPxbe'); //전체
    for(let eh of ehList){
        let title = await eh.$eval('div.mCBkyc.y355M.ynAwRc.MBeuO.nDgy9d', function(el){
            return el.innerText;
        });
        Title.push(title)
    }
    //——————————————————————————————————————————————
    let ehList1 = await page.$$('#rso > div > div >div'); //전체
    for(let eh of ehList1){
        let link = await eh.$eval("div > a", function(el){
            return el.getAttribute('href');
        });
        Link.push(link)
    }

    for(var i=0; i<Title.length; i++) {
        obj = {
            Title:Title[i],
            Link:Link[i]
        }
        const result = await mysql.query('newsInsert', obj)
    }
    browser.close();
}
parse1();


//게시판 정보 삽입
app.post('/board_insert' ,async(req,res) =>{
    var today = new Date;
     obj = {
        name : req.body.name,
        title : req.body.title,
        content : req.body.content,
        time : today.toLocaleDateString() + today.toLocaleTimeString()
    }
    console.log(obj)
    req.body.param = obj
    const result = await mysql.query('board_Insert', req.body.param);

    const gasipan = await mysql.query('board_List');
    console.log(gasipan);
    var step;

    const obj1 = [];

    for(step = 0; step < gasipan.length; step++){
        obj1[step] ={
        id : gasipan[step].id  ,
        name: gasipan[step].name  ,
        title: gasipan[step].title ,
        content: gasipan[step].content,
        time: gasipan[step].time }
    }   
        res.render('test2', {data: obj1})

});