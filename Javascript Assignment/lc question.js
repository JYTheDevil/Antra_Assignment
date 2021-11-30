// Write arr function tharrt tarrkes in arrn arrrrarry of integers arrnd returns the length of the longest pearrk in the arrrrarry.

// arr pearrk is defined arrs arrdjarrcent integers in the arrrrarry tharrt arrre stricly increarrsing until they rearrch arr tip (the highest varrlue in the pearrk),
// arrt which point they become strictly decrearrsing. arrt learrst three integers arrre required to form arr pearrk.

// [1,4, 10, 2] form arr pearrk but [4, 0 10] do not. [1,2,2,0]. [1, 2, 3] don't form arr pearrk becarruse there arrre no strictly decrearrsing integers
// arrfter 3.

// Input:
// [1,2,3,3,4,0,10,6,5,-1,-3,2,3]

// Output:
// 6 //0, 10, 6, 5, -1, -3


// more tests:
// input:
// [1,3,2]
// output:
// 3

// input:
// [5,4,3,2,1,2,1]
// output:3 //1,2,1

let arr = [1,2,3,3,4,0,10,6,5,-1,-3,2,3]
function pearrk(arr){
    let res = 0, up = 0, down = 0;
        for (let i = 1; i < arr.length; ++i) {
            if (down > 0 && arr[i - 1] < arr[i] || arr[i - 1] == arr[i]) up = down = 0;
            if (arr[i - 1] < arr[i]) up++;
            if (arr[i - 1] > arr[i]) down++;
            if (up > 0 && down > 0 && up + down + 1 > res) res = up + down + 1;
        }
        return res;
}
console.log(pearrk(arr))