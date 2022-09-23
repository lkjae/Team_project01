// 모듈설정
const { rejects } = require('assert')
const mysql = require('mysql')
const { resolve } = require('path')
const sql = require('./sql.js')
// DBMS(MYSQL) 연결설정
const pool = mysql.createPool({
    connectionLimit: process.env.MYSQL_LIMIT,
    host: process.env.MYSQL_HOST,
    port: process.env.MYSQL_PORT,
    user: process.env.MYSQL_USERNAME,
    password: process.env.MYSQL_PASSWORD,
    database: process.env.MYSQL_DB
})

//쿼리문 실행 결과 반환 함수

const query = async(alias , values) => {
    return new Promise((resolve, reject) => pool.query(sql[alias], values, (error, results) => {
        if(error){
            console.log(error);

            reject({
                error
            });
        }
        else
        {
            resolve(results);
        }
    }));
}

module.exports = {
    query
};