$(document).ready(function () {

    var pagePrefix = ".page-";
    var currentPage = $("#currentPage");
    var currentPageVal = currentPage.val();

    var nextPageBtn = $("#nextPageBtn");
    var prevPageBtn = $("#prevPageBtn");
    var submitBtn = $("#submitBtn");

    //Next page button click
    nextPageBtn.click(function (e) {
        changePage("forward");
    })

    //Previous page button click
    prevPageBtn.click(function (e) {
        changePage("backward");
    })

    function updatePagination() {
        switch (currentPageVal) {
            case 1:
                prevPageBtn.hide();
                break;
            case 3:
                nextPageBtn.hide();
                submitBtn.show();
                break;
            default:
                prevPageBtn.show();
                nextPageBtn.show();
                break;
        }
    }

    function changePage(direction) {
        var page = pagePrefix + currentPageVal;
        $(page).hide();

        //increment or decrement page
        if (direction == "forward") {
            currentPageVal++;
            prevPageBtn.show();
        }
        else if (direction = "backward") {
            currentPageVal--;
        }
        page = pagePrefix + currentPageVal;
        $(page).show();

        //update current page value
        currentPage.val(currentPageVal);
        updatePagination();
    }
})