
// **********question 1***************

// let salaries = {
//     John: 100,
//     Ann: 160,
//     Pete: 130
// }

// console.log(salaries.John+salaries.Ann+salaries.Pete)

// **********question 2***************

// let menu = {
//     width: 200,
//     height: 300,
//     title: "My menu"
// };

// function multiplyNumeric(obj) {
//     for (let key in obj) {
//       if (typeof obj[key] == 'number') {
//         obj[key] *= 2;
//       }
//     }
//   }

//   multiplyNumeric(menu)
//   console.log(menu.width)

// **********question 3***************

// let flag = false;
// function checkEmailId(str){
//     for (let i = 0; i < str.length; i++) {
//         if (str.charAt(i) == '@'){
//             for(let j = i + 2; j < str.length; j++){
//                 if(str.charAt(j) == '.'){
//                     flag = true;
//                 }
//             }
//         }        
//     }
//     console.log(flag)
// }

// checkEmailId("xxx.gmail@com")

// **********question 4***************

// function truncate(str, len){
//    let str2 = str.substring(0,len-1)
//    if(str.length > len){
//        str2 += "..."
//    }
//    console.log(str2)
// }
// truncate("What I'd like to tell on this topic is:", 20) 



// **********question 5***************

let arr = ["James", "Brennie"]
console.log(arr)

arr.push("Robert")
console.log(arr)

arr.splice(arr.length/2, 1, "Calvin")
console.log(arr)

arr.shift(arr)
console.log(arr)

arr.unshift("Rose", "Regal")
console.log(arr)
// **********question 6***************