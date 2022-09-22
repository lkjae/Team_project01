const express = require('express')
//DB설정 정보 가져오기
require('dotenv').config({path: 'mysql/.env'})

const mysql = require('./mysql')
const ejs = require('ejs')
const app = express()


/* 환경설정 */
//뷰엔진 설정
app.set('view engine', 'ejs')

var bodyParser = require('body-parser');
app.use(bodyParser.urlencoded({extended:true}));
app.use(bodyParser.json());

app.use(express.json({
    limit: '50mb'
}))
//Port Setting
var port = 3000;
app.listen(port, () => {
    console.log("Server Started port 3000...")
});


//게시판 입력
app.get('/board', function(req,res){    
    res.render('test1')                   
});

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
