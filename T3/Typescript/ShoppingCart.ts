// user type : enum : regular, premium
// product : name, price
// cart : prodects with price
// cart : user type === 'premium' ? disc = 10% : disc = 0%
// final price = price - (price * disc)

enum UserType {
    Regular = "regular",
    Premium = "premium"
}

type User = {
    name: string;
    userType: UserType;
}

type Product = {
    name: string;
    price: number;
}

type Cart = {
    user: User;
    items: Product[];
}

function calculateFinalPrice(cart: Cart): number {
    const totalPrice = cart.items.reduce((total, item) => total + item.price, 0);
    const discount = cart.user.userType === UserType.Premium ? 0.10 : 0;
    return totalPrice - (totalPrice * discount);
}

const product1: Product = {
    name: "Laptop",
    price: 50000
};

const product2: Product = {
    name: "Phone",
    price: 15000
};

const product3: Product = {
    name: "Buds",
    price: 5000
};

const product4: Product = {
    name: "Charger",
    price: 1000
};

const user1: User = {
    name: "ABC",
    userType: UserType.Regular
};

const user2: User = {
    name: "XYZ",
    userType: UserType.Premium
};

const cart1: Cart = {
    user: user1,
    items: [product1, product3]
};

const cart2: Cart = {
    user: user2,
    items: [product2, product3, product4]
};

console.log(`Final price for ${cart1.user.name}: INR ${calculateFinalPrice(cart1)}`);
console.log(`Final price for ${cart2.user.name}: INR ${calculateFinalPrice(cart2)}`);