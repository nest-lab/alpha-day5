const {split, matches} = require('lodash');
const {readFileSync} = require('fs');

const meaningful = (filePath)=>{
  const fileContent = readFileSync(filePath, {encoding: 'utf-8'});
  var result = matches('Mr. Seun. Today is great day for us', /[\.\!]+\s*|\n+\s*/);
  console.log(result);
}
//meaningful('court-transcript/Day3PMSession.txt');
meaningful('court-transcript/Lessig-court-transcript.txt');