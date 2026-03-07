let amount = 5002;
let discount =0;
if(amount>=5000){
    discount = 0.20*amount;
}else if(amount>=3000 && amount<5000){
    discount = 0.10*amount;
}else{
    discount=0;
}
let finalAmount = amount-discount;
console.log(`Discount amount for ${amount} is ${discount}`);
console.log(`Final amount for ${amount} is ${finalAmount}`);

