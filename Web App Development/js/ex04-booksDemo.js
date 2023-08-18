class Book{
    constructor(id, title, cost, author){
        this.id = id;
        this.title = title;
        this.price = cost
        this.author = author
    }

    display(){
        return `${this.title} is written by ${this.author} and its cost price is ${this.price}`
    }
}

class BookStore{
    constructor(){
        this.books = [
            new Book(111, "Ramayana", 400, "Shri Valmiki"),
            new Book(112, "A Suitable Boy", 450, "Vikram Seth"),
            new Book(113, "The Midnight's children", 600, "Salman Rushdie"),
            new Book(114, "2 States", 300, "Chetan Bhagat")
        ];
    }
    findBook = (id) => this.books.find((bk => bk.id == id));
    getAllBooks = () => this.books;
    addNewBook = (book) => this.books.push(book);
    updateDetails = (id, book) =>{
        let index = this.books.findIndex((bk) => bk.id == id);
        if(index == -1){
           alert("No book is found to update")
           return;     
        }
        this.books.splice(index, 1, book);
    }

    deleteBook = (id) =>{
        const index = this.books.findIndex((bk)=> bk.id == id);
        if(index < 0){
            alert("No book found to delete");
            return;
        }
        this.books.splice(index, 1);//insert, delete or update.
    }
}