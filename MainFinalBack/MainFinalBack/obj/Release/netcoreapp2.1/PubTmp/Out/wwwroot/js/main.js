// change height images of slider when window resize
$(document).ready(function () {
    SliderImageHeightIconButtonResizer();
    SliderPrevNextButtonsLeftRightChanger()
    $(window).resize(function () {
        SliderImageHeightIconButtonResizer();
        SliderPrevNextButtonsLeftRightChanger();
    });
    function SliderPrevNextButtonsLeftRightChanger() {
        if (window.innerWidth < 600) {
            $("#slider .carousel-control-prev").css("left", "0px")
            $("#slider .carousel-control-next").css("right", "0px")
        }
        else {
            $("#slider .carousel-control-prev").css("left", "50px")
            $("#slider .carousel-control-next").css("right", "50px")
        }
    }
    function SliderImageHeightIconButtonResizer() {
        if (window.innerWidth < 992) {
            $("#slider img").height(400);
            $("#slider .vip-icon").css("top", "5%")
            $("#slider .car-details").css({
                "font-size": "17px",
                "width": "100px",
                "height": "50px",
                "line-height": "50px"
            })
        }
        else if (window.innerWidth >= 992) {
            $("#slider img").height(800);
            $("#slider .vip-icon").css("top", "18%")
            $("#slider .car-details").css({
                "font-size": "20px",
                "width": "120px",
                "height": "70px",
                "line-height": "70px"
            })
        }
    }
});

//small screens sidebar menu
$(document).ready(function () {
    $(window).resize(function () {
        if (window.innerWidth > 992) {
            $("body").css("overflow-y", "unset");
            if ($("#small-screens #sidebar-btn").hasClass("collapsed")) {
                $("#small-screens #sidebar-btn").removeClass("collapsed");
                $("#small-screens #sidebar-btn").children().removeClass("w-100")
                $("#small-screens #sidebar").removeClass("visible")
            }
        }
    });
    $("#small-screens #sidebar-btn").click(function () {
        $("#small-screens #sidebar-btn").toggleClass("collapsed")
        $(this).children().toggleClass("w-100")
        $("#small-screens #sidebar").toggleClass("visible");
        if ($(this).hasClass("collapsed")) {
            $("body").css("overflow-y", "hidden")
        }
        else {
            $("body").css("overflow-y", "unset")
        }
    })
});

//menu position changer
$(document).ready(function () {
    LargeScreenMenuPositionChanger();
    document.addEventListener("scroll", function () {
        LargeScreenMenuPositionChanger();
    })
    function LargeScreenMenuPositionChanger() {
        if (document.scrollingElement.scrollTop > 42) {
            $("#large-screens .menubar").css({
                "position": "fixed",
                "width": "100%",
                "top": "0",
                "z-index": "9999999",
                "background-color": "rgba(17, 46, 59, 0.9)"
            })
        }
        else {
            $("#large-screens .menubar").css({
                "position": "unset",
                "background-color": "unset"
            })
        }
    }
});

//preloader
$(document).ready(function () {
    $("#preloader").hide();
});

//login page & register page & contact page line span width changer
$(document).ready(function () {
    $("#login .sign-in-input").focus(function () {
        LoginAndRegisterSpanLineWidthChanger("login", $(this));
    })
    $("#register .sign-in-input").focus(function () {
        LoginAndRegisterSpanLineWidthChanger("register", $(this));
    })
    $("#contact .sign-in-input").focus(function () {
        LoginAndRegisterSpanLineWidthChanger("contact", $(this));
    })
    function LoginAndRegisterSpanLineWidthChanger(section, input) {
        $(`#${section} .line`).css("width", "0%")
        $(input).next().css("width", "100%")
    }
});

//detail gallery
$(document).on("click", '[data-toggle="lightbox"]', function (event) {
    event.preventDefault();
    $(this).ekkoLightbox();
});

//car details tab changer and gallery img height resizer
$(document).ready(function () {
    $("#single-car-details .tabs a").click(function (e) {
        e.preventDefault();
        let dataId = $(this).parent().attr("data-id");
        $("#single-car-details .tabs li.active").removeClass("active");
        $(this).parent().addClass("active");
        $(`#single-car-details .tab-contents .tab-content.active`).removeClass("active")
        $(`#single-car-details .tab-contents .tab-content[data-id="${dataId}"]`).addClass("active");
        if (dataId == 3) {
            $(".detail-gallery img").each(function () {
                $(this).css("height", "auto")
            })
            PostGalleryImagesHeightResizer(0, "single-car-details");
        }
    })

    //single post gallery and car details gallery height resizer
    PostGalleryImagesHeightResizer(0, "post");
    PostGalleryImagesHeightResizer(0, "single-car-details");
    $(window).resize(function () {
        $(".detail-gallery img").each(function () {
            $(this).css("height", "auto")
        })
        PostGalleryImagesHeightResizer(0, "post");
        PostGalleryImagesHeightResizer(0, "single-car-details");
    });
    function PostGalleryImagesHeightResizer(height, sectionId) {
        $(`#${sectionId} .detail-gallery img`).each(function () {
            if ($(this).height() > height) {
                height = $(this).height()
            }
        });
        $(`#${sectionId} .detail-gallery img`).each(function () {
            $(this).height(height)
        });
    }
});

//blog list pagination
$(document).ready(function () {
    //general buttons
    $("#news-list .pagination-custom button.page").click(function () {
        BlogAjax($(this).attr("data-skip"), $("#news-list .pagination-custom button.active"), $(this).addClass("active"))
    })

    //forward button
    $("#news-list .pagination-custom button.forward").click(function () {
        if ($("#news-list .pagination-custom button.active").attr("data-id") == "last-page") {
            return;
        }
        let nextBTN = $("#news-list .pagination-custom button.active").next();
        BlogAjax($(nextBTN).attr("data-skip"), $("#news-list .pagination-custom button.active"), nextBTN)
    })

    //backward button
    $("#news-list .pagination-custom button.backward").click(function () {
        if ($("#news-list .pagination-custom button.active").attr("data-id") == "first-page") {
            return;
        }
        let prevBTN = $("#news-list .pagination-custom button.active").prev();
        BlogAjax($(prevBTN).attr("data-skip"), $("#news-list .pagination-custom button.active"), prevBTN)
    })

    //fast backward button
    $("#news-list .pagination-custom button.fast-backward").click(function () {
        if ($("#news-list .pagination-custom button.active").attr("data-id") == "first-page") {
            return;
        }
        BlogAjax($('#news-list .pagination-custom button[data-id="first-page"]').attr("data-skip"),
            $("#news-list .pagination-custom button.active"),
            $('#news-list .pagination-custom button[data-id="first-page"]'))
    })

    //fast forward button
    $("#news-list .pagination-custom button.fast-forward").click(function () {
        if ($("#news-list .pagination-custom button.active").attr("data-id") == "last-page") {
            return;
        }
        BlogAjax($('#news-list .pagination-custom button[data-id="last-page"]').attr("data-skip"),
            $("#news-list .pagination-custom button.active"),
            $('#news-list .pagination-custom button[data-id="last-page"]'))
    })

    //common function for ajax buttons.
    //skip - how many blogs will skip
    //oldActiveBtn - which button is active for remove active class
    //newActiveBtn - add active class clicked button or next or prev buttons
    function BlogAjax(skip, oldActiveBtn, newActiveBtn) {
        $.ajax({
            url: "Ajax/LoadBlogs?skip=" + skip,
            type: "GET",
            success: function (res) {
                $("#news-list .col-lg-8 .single-news").remove();
                $("#news-list .col-lg-8").prepend(res);
                oldActiveBtn.removeClass("active")
                newActiveBtn.addClass("active")
            }
        })
    }
});

//home page news img height resizer || recent news
$(document).ready(function () {
    let height = 0;
    NewsHeightResizer("#news .single-news .image a img", height);
    NewsHeightResizer("#news .single-news .title", height);
    NewsHeightResizer(".recent-news .news .single-news .image img", height)
    $(window).resize(function () {
        let height = 0;
        NewsHeightResizer("#news .single-news .image a img", height);
        NewsHeightResizer("#news .single-news .title", height);
        NewsHeightResizer(".recent-news .news .single-news .image img", height)
    })
    function NewsHeightResizer(whichHeightIs, height) {
        $(whichHeightIs).height("auto")
        $(whichHeightIs).each(function () {
            if ($(this).height() > height) {
                height = $(this).height()
            }
        })
        $(whichHeightIs).each(function () {
            $(this).height(height)
        })
    }
})

//car search ajaxs
$(document).ready(function () {
    $("#cars #countries").change(function () {
        let countryId = $(this).val();
        if (countryId == "") {
            $("#cars #cities").html("<option value=''>Select City</option>")
        }
        if (countryId) {
            $.ajax({
                url: "/ajax/LoadCitiesByCountryId?countryId=" + countryId,
                type: "GET",
                success: function (res) {
                    $("#cars #cities").html(res)
                    $("#cars #cities").prepend("<option value=''>Select City</option>")
                    $("#cars #cities").val("")
                }
            });
        }
    })
    $("#cars #brands").change(function () {
        let brandId = $(this).val();
        if (brandId == "") {
            $("#cars #models").html("<option value=''>Select Model</option>")
        }
        if (brandId) {
            $.ajax({
                url: "/ajax/LoadModelsByBrandId?brandId=" + brandId,
                type: "GET",
                success: function (res) {
                    $("#cars #models").html(res)
                    $("#cars #models").prepend("<option value=''>Select Model</option>")
                    $("#cars #models").val("")
                }
            });
        }
    })
})

$(document).ready(function () {
    $("#cars #models").change(function () {
        let modelId = $("#cars #models").val();
        let categoryId = $("#cars #categories").val();
        let cityId = $("#cars #cities").val();
        $.ajax({
            url: "/ajax/LoadCars",
            type: "GET",
            data: {
                "modelId": modelId,
                "categoryId": categoryId,
                "cityId": cityId,
                "skip": 0
            },
            beforeSend: function () {
                $("#cars .car-list").html("")
                $("#cars .load-more").addClass("d-none")
                $("#cars #loader").addClass("d-flex")
            },
            success: function (res) {
                $("#cars #loader").removeClass("d-flex")
                $("#cars .load-more").removeClass("d-none")
                $("#cars .car-list").html(res)
                LoadMoreBTN();
            }
        })
    })
    $("#cars #cities").change(function () {
        let modelId = $("#cars #models").val();
        let categoryId = $("#cars #categories").val();
        let cityId = $("#cars #cities").val();
        $.ajax({
            url: "/ajax/LoadCars",
            type: "GET",
            data: {
                "modelId": modelId,
                "categoryId": categoryId,
                "cityId": cityId,
                "skip": 0
            },
            beforeSend: function () {
                $("#cars .car-list").html("")
                $("#cars .load-more").addClass("d-none")
                $("#cars #loader").addClass("d-flex")
            },
            success: function (res) {
                $("#cars #loader").removeClass("d-flex")
                $("#cars .load-more").removeClass("d-none")
                $("#cars .car-list").html(res)
                LoadMoreBTN();
            }
        })
    })
    $("#cars #categories").change(function () {
        let modelId = $("#cars #models").val();
        let categoryId = $("#cars #categories").val();
        let cityId = $("#cars #cities").val();
        $.ajax({
            url: "/ajax/LoadCars",
            type: "GET",
            data: {
                "modelId": modelId,
                "categoryId": categoryId,
                "cityId": cityId,
                "skip": 0
            },
            beforeSend: function () {
                $("#cars .car-list").html("")
                $("#cars .load-more").addClass("d-none")
                $("#cars #loader").addClass("d-flex")
            },
            success: function (res) {
                $("#cars #loader").removeClass("d-flex")
                $("#cars .load-more").removeClass("d-none")
                $("#cars .car-list").html(res)
                LoadMoreBTN();
            }
        })
    })

    $(document).on("click", "#cars .load-more a", function (e) {
        e.preventDefault();
        let modelId = $("#cars #models").val();
        let categoryId = $("#cars #categories").val();
        let cityId = $("#cars #cities").val();
        let takenCars = $("#cars #takenCars").val();
        $.ajax({
            url: "/ajax/LoadCars",
            type: "GET",
            data: {
                "modelId": modelId,
                "categoryId": categoryId,
                "cityId": cityId,
                "skip": parseInt(takenCars)
            },
            beforeSend: function () {
                $("#cars .load-more").addClass("d-none")
                $("#cars #loader").addClass("d-flex")

            },
            success: function (res) {
                $("#cars .load-more").removeClass("d-none")
                $("#cars #loader").removeClass("d-flex")
                $("#cars .car-list").append(res)
                $("#cars #takenCars").val(parseInt(takenCars) + 3);
                if (parseInt($("#cars #count").val()) <= (parseInt(takenCars) + 3)) {
                    $("#cars .load-more").remove()
                }
            }
        })
    })
    function LoadMoreBTN() {
        if ($("#cars #count").val() <= 3) {
            $("#cars .load-more").remove()
        }
        else {
            if (document.querySelector("#cars .load-more") == null) {
                let loadMoreDiv = document.createElement("div");
                let col12 = document.createElement("div");
                let button = document.createElement("a");
                $(button).attr("href", "")
                button.text = "Load more";
                $(col12).addClass("text-center col-12");
                $(loadMoreDiv).addClass("row load-more");
                $(button).addClass("btn");
                $(col12).append(button);
                $(loadMoreDiv).append(col12);
                $("#cars .container").append(loadMoreDiv)
            }
        }
    }

})

$(document).ready(function () {
    $("#reservation .buttons .reserve").click(function (e) {
        e.preventDefault();
        $(this).next().removeClass("d-none");
        let pickYear = parseInt($("#reservation #Order_PickDate").val().substr(0, 4))
        let pickMonth = parseInt($("#reservation #Order_PickDate").val().substr(5, 2))
        let pickDay = parseInt($("#reservation #Order_PickDate").val().substr(8, 2))
        let returnYear = parseInt($("#reservation #Order_ReturnDate").val().substr(0, 4))
        let returnMonth = parseInt($("#reservation #Order_ReturnDate").val().substr(5, 2))
        let returnDay = parseInt($("#reservation #Order_ReturnDate").val().substr(8, 2))
        let sum = 0;
        if (isNaN(pickDay) || isNaN(pickMonth) || isNaN(pickYear) || isNaN(returnDay) || isNaN(returnMonth) || isNaN(returnYear)) {
            $("#reservation #alert").html("<strong>Please input valid dates</strong>")
        }
        if ((returnYear - pickYear) > 0) {
            sum = (returnYear - pickYear) * 365
            if ((returnMonth - pickMonth) != 0) {
                if ((returnMonth - pickMonth) < 0) {
                    sum = sum + (-(returnMonth - pickMonth)) * 30
                }
                else {
                    sum = sum + (returnMonth - pickMonth) * 30
                }
            }
            if ((returnDay - pickDay) != 0) {
                if ((returnDay - pickDay) < 0) {
                    sum = sum + (-(returnDay - pickDay))
                }
                else {
                    sum = sum + (returnDay - pickDay)
                }
            }
        }
        if ((returnYear - pickYear) == 0) {
            if ((returnMonth - pickMonth) >= 0) {
                if ((returnMonth - pickMonth) > 0) {
                    sum = sum + (returnMonth - pickMonth) * 30
                    if ((returnDay - pickDay) > 0) {
                        sum = sum + (returnDay - pickDay)
                    }
                    if ((returnDay - pickDay) < 0) {
                        sum = sum + (-(returnDay - pickDay))
                    }
                }
                else {
                    if ((returnDay - pickDay) > 0) {
                        sum = sum + (returnDay - pickDay)
                    }
                }
            }
        }
        if (sum > 0) {
            $("#reservation #alert").html(`Your order's cost: <strong class="price"> $</strong>, Are you sure?
                            <button type="button" class="ml-3 cancel">
                                <i class="fas fa-times"></i>
                            </button>`)
            $("#reservation #alert .price").html(parseInt($("#reservation #AdPrice").val()) * sum + "$")
        }
        else {
            $("#reservation #alert").html("<strong>Please input valid dates</strong>")
        }
        console.log(sum)
    })
    $(document).on("click", "#reservation .cancel", function (e) {
        e.preventDefault()
        $("#reservation #Order_PickDate").val("")
        $("#reservation #Order_ReturnDate").val("")
        $(this).parent().addClass("d-none")
    })
    $("#reservation form input").each(function () {
        $(this).focus(function () {
            $("#reservation .buttons div").addClass("d-none")
        })
    })
})

$(document).ready(function () {
    $(document).on("click", "#single-car-details .delete", function (e) {
        e.preventDefault();
        let id = $(this).attr("data-id");
        $.ajax({
            url: "/ajax/DeleteReview?id=" + id,
            type: "GET",
            success: function (res) {
                $("#single-car-details div[data-id=4] .comments").html("")
                $("#single-car-details div[data-id=4] .comments").html(res)
            }
        })
    })
})