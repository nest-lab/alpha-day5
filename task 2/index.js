const {readdirSync, readFileSync, lstatSync} = require('fs');
const path = require('path');
const externalModules = ['node_modules'];

const totalLines = (projectDir)=>{
  var countedLine = 0;
  for(let i=0; i<projectDir.length; i++){
    if(externalModules.indexOf(projectDir[i]) === -1 && lstatSync(projectDir[i]).isFile()){
      countedLine = countedLine + countLines(projectDir[i]);
      continue;
    }
  }
  return countedLine;  
}

const countLines = (fileName)=>{
  var contentByLines = readFileSync(fileName, {encoding: 'utf-8'}).split('\n');
  return contentByLines.length;
}

//USE CASE:
const projectDir = readdirSync(__dirname);

console.log(totalLines(projectDir));