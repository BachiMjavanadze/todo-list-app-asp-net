const searchInput = document.getElementById("search-input");

searchInput.addEventListener("keyup", (e) => {
    let searchInput = document.getElementById("search-input");
    let filter = searchInput.value.toUpperCase();
    let todoList = document.getElementById("todo-list");
    let todoItem = todoList.getElementsByClassName("todo-item");

    for (let i = 0; i < todoItem.length; i++) {
        let todoName = todoItem[i].getElementsByClassName("todo-name")[0];
        let txtValue = todoName.textContent || todoName.innerText;

        if (txtValue.toUpperCase().includes(filter)) {
            todoItem[i].style.display = "";
        } else {
            todoItem[i].style.display = "none";
        }
    }
})

searchInput.addEventListener("input", function () {
    let isInputEmpty = !searchInput.value.trim().length;

    if (isInputEmpty) {
        let elements = document.getElementsByClassName("todo-item");

        for (let i = 0; i < elements.length; i++) {
            elements[i].style.display = "";
        }
    }
});