let arr = [1, 2, 3, 4, 5];
console.log(arr);

console.log(arr.push(6));
console.log(arr);

arr.pop();
console.log(arr)

arr.shift();
console.log(arr);

arr.unshift(0);
console.log(arr);

console.log(arr.map(x => x * 2));

console.log(arr.filter(x => x % 2 === 0));