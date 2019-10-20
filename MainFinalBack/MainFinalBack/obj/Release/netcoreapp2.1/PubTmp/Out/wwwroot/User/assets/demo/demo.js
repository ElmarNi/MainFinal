type = ['primary', 'info', 'success', 'warning', 'danger'];

demo = {
  initPickColor: function() {
    $('.pick-class-label').click(function() {
      var new_class = $(this).attr('new-class');
      var old_class = $('#display-buttons').attr('data-class');
      var display_div = $('#display-buttons');
      if (display_div.length) {
        var display_buttons = display_div.find('.btn');
        display_buttons.removeClass(old_class);
        display_buttons.addClass(new_class);
        display_div.attr('data-class', new_class);
      }
    });
  },

  initDocChart: function() {
    chartColor = "#FFFFFF";

    // General configuration for the charts with Line gradientStroke
    gradientChartOptionsConfiguration = {
      maintainAspectRatio: false,
      legend: {
        display: false
      },
      tooltips: {
        bodySpacing: 4,
        mode: "nearest",
        intersect: 0,
        position: "nearest",
        xPadding: 10,
        yPadding: 10,
        caretPadding: 10
      },
      responsive: true,
      scales: {
        yAxes: [{
          display: 0,
          gridLines: 0,
          ticks: {
            display: false
          },
          gridLines: {
            zeroLineColor: "transparent",
            drawTicks: false,
            display: false,
            drawBorder: false
          }
        }],
        xAxes: [{
          display: 0,
          gridLines: 0,
          ticks: {
            display: false
          },
          gridLines: {
            zeroLineColor: "transparent",
            drawTicks: false,
            display: false,
            drawBorder: false
          }
        }]
      },
      layout: {
        padding: {
          left: 0,
          right: 0,
          top: 15,
          bottom: 15
        }
      }
    };

    ctx = document.getElementById('lineChartExample').getContext("2d");

    gradientStroke = ctx.createLinearGradient(500, 0, 100, 0);
    gradientStroke.addColorStop(0, '#80b6f4');
    gradientStroke.addColorStop(1, chartColor);

    gradientFill = ctx.createLinearGradient(0, 170, 0, 50);
    gradientFill.addColorStop(0, "rgba(128, 182, 244, 0)");
    gradientFill.addColorStop(1, "rgba(249, 99, 59, 0.40)");

    myChart = new Chart(ctx, {
      type: 'line',
      responsive: true,
      data: {
        labels: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"],
        datasets: [{
          label: "Active Users",
          borderColor: "#f96332",
          pointBorderColor: "#FFF",
          pointBackgroundColor: "#f96332",
          pointBorderWidth: 2,
          pointHoverRadius: 4,
          pointHoverBorderWidth: 1,
          pointRadius: 4,
          fill: true,
          backgroundColor: gradientFill,
          borderWidth: 2,
          data: [542, 480, 430, 550, 530, 453, 380, 434, 568, 610, 700, 630]
        }]
      },
      options: gradientChartOptionsConfiguration
    });
  },

  initDashboardPageCharts: function() {

    gradientChartOptionsConfigurationWithTooltipBlue = {
      maintainAspectRatio: false,
      legend: {
        display: false
      },

      tooltips: {
        backgroundColor: '#f5f5f5',
        titleFontColor: '#333',
        bodyFontColor: '#666',
        bodySpacing: 4,
        xPadding: 12,
        mode: "nearest",
        intersect: 0,
        position: "nearest"
      },
      responsive: true,
      scales: {
        yAxes: [{
          barPercentage: 1.6,
          gridLines: {
            drawBorder: false,
            color: 'rgba(29,140,248,0.0)',
            zeroLineColor: "transparent",
          },
          ticks: {
            suggestedMin: 60,
            suggestedMax: 125,
            padding: 20,
            fontColor: "#2380f7"
          }
        }],

        xAxes: [{
          barPercentage: 1.6,
          gridLines: {
            drawBorder: false,
            color: 'rgba(29,140,248,0.1)',
            zeroLineColor: "transparent",
          },
          ticks: {
            padding: 20,
            fontColor: "#2380f7"
          }
        }]
      }
    };

    gradientChartOptionsConfigurationWithTooltipPurple = {
      maintainAspectRatio: false,
      legend: {
        display: false
      },

      tooltips: {
        backgroundColor: '#f5f5f5',
        titleFontColor: '#333',
        bodyFontColor: '#666',
        bodySpacing: 4,
        xPadding: 12,
        mode: "nearest",
        intersect: 0,
        position: "nearest"
      },
      responsive: true,
      scales: {
        yAxes: [{
          barPercentage: 1.6,
          gridLines: {
            drawBorder: false,
            color: 'rgba(29,140,248,0.0)',
            zeroLineColor: "transparent",
          },
          ticks: {
            suggestedMin: 60,
            suggestedMax: 125,
            padding: 20,
            fontColor: "#9a9a9a"
          }
        }],

        xAxes: [{
          barPercentage: 1.6,
          gridLines: {
            drawBorder: false,
            color: 'rgba(225,78,202,0.1)',
            zeroLineColor: "transparent",
          },
          ticks: {
            padding: 20,
            fontColor: "#9a9a9a"
          }
        }]
      }
    };

    gradientChartOptionsConfigurationWithTooltipOrange = {
      maintainAspectRatio: false,
      legend: {
        display: false
      },

      tooltips: {
        backgroundColor: '#f5f5f5',
        titleFontColor: '#333',
        bodyFontColor: '#666',
        bodySpacing: 4,
        xPadding: 12,
        mode: "nearest",
        intersect: 0,
        position: "nearest"
      },
      responsive: true,
      scales: {
        yAxes: [{
          barPercentage: 1.6,
          gridLines: {
            drawBorder: false,
            color: 'rgba(29,140,248,0.0)',
            zeroLineColor: "transparent",
          },
          ticks: {
            suggestedMin: 50,
            suggestedMax: 110,
            padding: 20,
            fontColor: "#ff8a76"
          }
        }],

        xAxes: [{
          barPercentage: 1.6,
          gridLines: {
            drawBorder: false,
            color: 'rgba(220,53,69,0.1)',
            zeroLineColor: "transparent",
          },
          ticks: {
            padding: 20,
            fontColor: "#ff8a76"
          }
        }]
      }
    };

    gradientChartOptionsConfigurationWithTooltipGreen = {
      maintainAspectRatio: false,
      legend: {
        display: false
      },

      tooltips: {
        backgroundColor: '#f5f5f5',
        titleFontColor: '#333',
        bodyFontColor: '#666',
        bodySpacing: 4,
        xPadding: 12,
        mode: "nearest",
        intersect: 0,
        position: "nearest"
      },
      responsive: true,
      scales: {
        yAxes: [{
          barPercentage: 1.6,
          gridLines: {
            drawBorder: false,
            color: 'rgba(29,140,248,0.0)',
            zeroLineColor: "transparent",
          },
          ticks: {
            suggestedMin: 50,
            suggestedMax: 125,
            padding: 20,
            fontColor: "#9e9e9e"
          }
        }],

        xAxes: [{
          barPercentage: 1.6,
          gridLines: {
            drawBorder: false,
            color: 'rgba(0,242,195,0.1)',
            zeroLineColor: "transparent",
          },
          ticks: {
            padding: 20,
            fontColor: "#9e9e9e"
          }
        }]
      }
    };


    gradientBarChartConfiguration = {
      maintainAspectRatio: false,
      legend: {
        display: false
      },

      tooltips: {
        backgroundColor: '#f5f5f5',
        titleFontColor: '#333',
        bodyFontColor: '#666',
        bodySpacing: 4,
        xPadding: 12,
        mode: "nearest",
        intersect: 0,
        position: "nearest"
      },
      responsive: true,
      scales: {
        yAxes: [{

          gridLines: {
            drawBorder: false,
            color: 'rgba(29,140,248,0.1)',
            zeroLineColor: "transparent",
          },
          ticks: {
            suggestedMin: 60,
            suggestedMax: 120,
            padding: 20,
            fontColor: "#9e9e9e"
          }
        }],

        xAxes: [{

          gridLines: {
            drawBorder: false,
            color: 'rgba(29,140,248,0.1)',
            zeroLineColor: "transparent",
          },
          ticks: {
            padding: 20,
            fontColor: "#9e9e9e"
          }
        }]
      }
    };

    var ctx = document.getElementById("chartLinePurple").getContext("2d");

    var gradientStroke = ctx.createLinearGradient(0, 230, 0, 50);

    gradientStroke.addColorStop(1, 'rgba(72,72,176,0.2)');
    gradientStroke.addColorStop(0.2, 'rgba(72,72,176,0.0)');
    gradientStroke.addColorStop(0, 'rgba(119,52,169,0)'); //purple colors

    var data = {
      labels: ['JUL', 'AUG', 'SEP', 'OCT', 'NOV', 'DEC'],
      datasets: [{
        label: "Data",
        fill: true,
        backgroundColor: gradientStroke,
        borderColor: '#d048b6',
        borderWidth: 2,
        borderDash: [],
        borderDashOffset: 0.0,
        pointBackgroundColor: '#d048b6',
        pointBorderColor: 'rgba(255,255,255,0)',
        pointHoverBackgroundColor: '#d048b6',
        pointBorderWidth: 20,
        pointHoverRadius: 4,
        pointHoverBorderWidth: 15,
        pointRadius: 4,
        data: [80, 100, 70, 80, 120, 80],
      }]
    };

    var myChart = new Chart(ctx, {
      type: 'line',
      data: data,
      options: gradientChartOptionsConfigurationWithTooltipPurple
    });


    var ctxGreen = document.getElementById("chartLineGreen").getContext("2d");

    var gradientStroke = ctx.createLinearGradient(0, 230, 0, 50);

    gradientStroke.addColorStop(1, 'rgba(66,134,121,0.15)');
    gradientStroke.addColorStop(0.4, 'rgba(66,134,121,0.0)'); //green colors
    gradientStroke.addColorStop(0, 'rgba(66,134,121,0)'); //green colors

    var data = {
      labels: ['JUL', 'AUG', 'SEP', 'OCT', 'NOV'],
      datasets: [{
        label: "My First dataset",
        fill: true,
        backgroundColor: gradientStroke,
        borderColor: '#00d6b4',
        borderWidth: 2,
        borderDash: [],
        borderDashOffset: 0.0,
        pointBackgroundColor: '#00d6b4',
        pointBorderColor: 'rgba(255,255,255,0)',
        pointHoverBackgroundColor: '#00d6b4',
        pointBorderWidth: 20,
        pointHoverRadius: 4,
        pointHoverBorderWidth: 15,
        pointRadius: 4,
        data: [90, 27, 60, 12, 80],
      }]
    };

    var myChart = new Chart(ctxGreen, {
      type: 'line',
      data: data,
      options: gradientChartOptionsConfigurationWithTooltipGreen

    });



    var chart_labels = ['JAN', 'FEB', 'MAR', 'APR', 'MAY', 'JUN', 'JUL', 'AUG', 'SEP', 'OCT', 'NOV', 'DEC'];
    var chart_data = [100, 70, 90, 70, 85, 60, 75, 60, 90, 80, 110, 100];


    var ctx = document.getElementById("chartBig1").getContext('2d');

    var gradientStroke = ctx.createLinearGradient(0, 230, 0, 50);

    gradientStroke.addColorStop(1, 'rgba(72,72,176,0.1)');
    gradientStroke.addColorStop(0.4, 'rgba(72,72,176,0.0)');
    gradientStroke.addColorStop(0, 'rgba(119,52,169,0)'); //purple colors
    var config = {
      type: 'line',
      data: {
        labels: chart_labels,
        datasets: [{
          label: "My First dataset",
          fill: true,
          backgroundColor: gradientStroke,
          borderColor: '#d346b1',
          borderWidth: 2,
          borderDash: [],
          borderDashOffset: 0.0,
          pointBackgroundColor: '#d346b1',
          pointBorderColor: 'rgba(255,255,255,0)',
          pointHoverBackgroundColor: '#d346b1',
          pointBorderWidth: 20,
          pointHoverRadius: 4,
          pointHoverBorderWidth: 15,
          pointRadius: 4,
          data: chart_data,
        }]
      },
      options: gradientChartOptionsConfigurationWithTooltipPurple
    };
    var myChartData = new Chart(ctx, config);
    $("#0").click(function() {
      var data = myChartData.config.data;
      data.datasets[0].data = chart_data;
      data.labels = chart_labels;
      myChartData.update();
    });
    $("#1").click(function() {
      var chart_data = [80, 120, 105, 110, 95, 105, 90, 100, 80, 95, 70, 120];
      var data = myChartData.config.data;
      data.datasets[0].data = chart_data;
      data.labels = chart_labels;
      myChartData.update();
    });

    $("#2").click(function() {
      var chart_data = [60, 80, 65, 130, 80, 105, 90, 130, 70, 115, 60, 130];
      var data = myChartData.config.data;
      data.datasets[0].data = chart_data;
      data.labels = chart_labels;
      myChartData.update();
    });


    var ctx = document.getElementById("CountryChart").getContext("2d");

    var gradientStroke = ctx.createLinearGradient(0, 230, 0, 50);

    gradientStroke.addColorStop(1, 'rgba(29,140,248,0.2)');
    gradientStroke.addColorStop(0.4, 'rgba(29,140,248,0.0)');
    gradientStroke.addColorStop(0, 'rgba(29,140,248,0)'); //blue colors


    var myChart = new Chart(ctx, {
      type: 'bar',
      responsive: true,
      legend: {
        display: false
      },
      data: {
        labels: ['USA', 'GER', 'AUS', 'UK', 'RO', 'BR'],
        datasets: [{
          label: "Countries",
          fill: true,
          backgroundColor: gradientStroke,
          hoverBackgroundColor: gradientStroke,
          borderColor: '#1f8ef1',
          borderWidth: 2,
          borderDash: [],
          borderDashOffset: 0.0,
          data: [53, 20, 10, 80, 100, 45],
        }]
      },
      options: gradientBarChartConfiguration
    });

  },

  initGoogleMaps: function() {
    var myLatlng = new google.maps.LatLng(40.748817, -73.985428);
    var mapOptions = {
      zoom: 13,
      center: myLatlng,
      scrollwheel: false, //we disable de scroll over the map, it is a really annoing when you scroll through page
      styles: [{
          "elementType": "geometry",
          "stylers": [{
            "color": "#1d2c4d"
          }]
        },
        {
          "elementType": "labels.text.fill",
          "stylers": [{
            "color": "#8ec3b9"
          }]
        },
        {
          "elementType": "labels.text.stroke",
          "stylers": [{
            "color": "#1a3646"
          }]
        },
        {
          "featureType": "administrative.country",
          "elementType": "geometry.stroke",
          "stylers": [{
            "color": "#4b6878"
          }]
        },
        {
          "featureType": "administrative.land_parcel",
          "elementType": "labels.text.fill",
          "stylers": [{
            "color": "#64779e"
          }]
        },
        {
          "featureType": "administrative.province",
          "elementType": "geometry.stroke",
          "stylers": [{
            "color": "#4b6878"
          }]
        },
        {
          "featureType": "landscape.man_made",
          "elementType": "geometry.stroke",
          "stylers": [{
            "color": "#334e87"
          }]
        },
        {
          "featureType": "landscape.natural",
          "elementType": "geometry",
          "stylers": [{
            "color": "#023e58"
          }]
        },
        {
          "featureType": "poi",
          "elementType": "geometry",
          "stylers": [{
            "color": "#283d6a"
          }]
        },
        {
          "featureType": "poi",
          "elementType": "labels.text.fill",
          "stylers": [{
            "color": "#6f9ba5"
          }]
        },
        {
          "featureType": "poi",
          "elementType": "labels.text.stroke",
          "stylers": [{
            "color": "#1d2c4d"
          }]
        },
        {
          "featureType": "poi.park",
          "elementType": "geometry.fill",
          "stylers": [{
            "color": "#023e58"
          }]
        },
        {
          "featureType": "poi.park",
          "elementType": "labels.text.fill",
          "stylers": [{
            "color": "#3C7680"
          }]
        },
        {
          "featureType": "road",
          "elementType": "geometry",
          "stylers": [{
            "color": "#304a7d"
          }]
        },
        {
          "featureType": "road",
          "elementType": "labels.text.fill",
          "stylers": [{
            "color": "#98a5be"
          }]
        },
        {
          "featureType": "road",
          "elementType": "labels.text.stroke",
          "stylers": [{
            "color": "#1d2c4d"
          }]
        },
        {
          "featureType": "road.highway",
          "elementType": "geometry",
          "stylers": [{
            "color": "#2c6675"
          }]
        },
        {
          "featureType": "road.highway",
          "elementType": "geometry.fill",
          "stylers": [{
            "color": "#9d2a80"
          }]
        },
        {
          "featureType": "road.highway",
          "elementType": "geometry.stroke",
          "stylers": [{
            "color": "#9d2a80"
          }]
        },
        {
          "featureType": "road.highway",
          "elementType": "labels.text.fill",
          "stylers": [{
            "color": "#b0d5ce"
          }]
        },
        {
          "featureType": "road.highway",
          "elementType": "labels.text.stroke",
          "stylers": [{
            "color": "#023e58"
          }]
        },
        {
          "featureType": "transit",
          "elementType": "labels.text.fill",
          "stylers": [{
            "color": "#98a5be"
          }]
        },
        {
          "featureType": "transit",
          "elementType": "labels.text.stroke",
          "stylers": [{
            "color": "#1d2c4d"
          }]
        },
        {
          "featureType": "transit.line",
          "elementType": "geometry.fill",
          "stylers": [{
            "color": "#283d6a"
          }]
        },
        {
          "featureType": "transit.station",
          "elementType": "geometry",
          "stylers": [{
            "color": "#3a4762"
          }]
        },
        {
          "featureType": "water",
          "elementType": "geometry",
          "stylers": [{
            "color": "#0e1626"
          }]
        },
        {
          "featureType": "water",
          "elementType": "labels.text.fill",
          "stylers": [{
            "color": "#4e6d70"
          }]
        }
      ]
    };

    var map = new google.maps.Map(document.getElementById("map"), mapOptions);

    var marker = new google.maps.Marker({
      position: myLatlng,
      title: "Hello World!"
    });

    // To add the marker to the map, call setMap();
    marker.setMap(map);
  },

  showNotification: function(from, align) {
    color = Math.floor((Math.random() * 4) + 1);

    $.notify({
      icon: "tim-icons icon-bell-55",
      message: "Welcome to <b>Black Dashboard</b> - a beautiful freebie for every web developer."

    }, {
      type: type[color],
      timer: 8000,
      placement: {
        from: from,
        align: align
      }
    });
  }

};

//ads blogs delete btton
$(document).ready(function () {
    $("#ads #delete").click(function (e) {
        e.preventDefault();
        DeleteButton($(this))
    })
    $("#ads #cancel").click(function (e) {
        e.preventDefault();
        DeleteButtonCancel($(this));
    })
    $("#terms #delete").click(function (e) {
        e.preventDefault();
        DeleteButton($(this))
    })
    $("#terms #cancel").click(function (e) {
        e.preventDefault();
        DeleteButtonCancel($(this));
    })
    $("#blogs #delete").click(function (e) {
        e.preventDefault();
        DeleteButton($(this))
    })
    $("#blogs #cancel").click(function (e) {
        e.preventDefault();
        DeleteButtonCancel($(this));
    })
    function DeleteButton(button) {
        $(button).next().removeClass("d-none").addClass("d-flex");
        $(button).addClass("d-none")
    }
    function DeleteButtonCancel(button) {
        $(button).parent().removeClass("d-flex").addClass("d-none");
        $(button).parent().prev().removeClass("d-none")
    }
})

//ad edit detail images
$(document).ready(function () {
    $("#adEdit #detailImages .detail-image-single img").click(function () {
        $(this).next().removeClass("d-none").addClass("d-flex");
        $(this).addClass("d-none")
    })
    $("#adEdit #detailImages .detail-image-single #cancel").click(function (e) {
        e.preventDefault();
        $(this).parent().removeClass("d-flex").addClass("d-none");
        $(this).parent().prev().removeClass("d-none")
    })
    $("#blogEdit #detailImages .detail-image-single img").click(function () {
        $(this).next().removeClass("d-none").addClass("d-flex");
        $(this).addClass("d-none")
    })
    $("#blogEdit #detailImages .detail-image-single #cancel").click(function (e) {
        e.preventDefault();
        $(this).parent().removeClass("d-flex").addClass("d-none");
        $(this).parent().prev().removeClass("d-none")
    })
    DetailImageWidthResizer("#adEdit");
    DetailImageWidthResizer("#adCreate");
    DetailImageWidthResizer("#blogCreate");
    DetailImageWidthResizer("#blogEdit")
    DetailImageWidthResizer("#adDetails")
    $(window).resize(function () {
        DetailImageWidthResizer("#adEdit");
        DetailImageWidthResizer("#adCreate");
        DetailImageWidthResizer("#blogCreate");
        DetailImageWidthResizer("#blogEdit");
        DetailImageWidthResizer("#adDetails")
    })
    $("#adEdit #confirmDelete").click(function (e) {
        e.preventDefault();
        let id = $(this).attr("data-id");
        let removeItem = $(this).parent().parent();
        $.ajax({
            url: "/ajax/DeleteDetailImage?id=" + id,
            type: "get",
            success: function () {
                $(removeItem).remove();
            }
        })
    })
    $("#blogEdit #confirmDelete").click(function (e) {
        e.preventDefault();
        let id = $(this).attr("data-id");
        let removeItem = $(this).parent().parent();
        $.ajax({
            url: "/ajax/DeleteDetailImageBlog?id=" + id,
            type: "get",
            success: function () {
                $(removeItem).remove();
            }
        })
    })
    $("#adCreate #add-photo #Car_DetailPhotos").change(function () {
        $("#adCreate .laterAdded").remove()
        let parentInput = $(this).parent();
        if (this.files) {
            for (i = 0; i < this.files.length; i++) {
                var reader = new FileReader();
                reader.onload = function (event) {
                    let mainDiv = document.createElement("div");
                    $(mainDiv).addClass("detail-image-single laterAdded");
                    let image = document.createElement("img");
                    $(image).attr('src', event.target.result).appendTo(mainDiv);
                    $(mainDiv).insertBefore(parentInput)
                    DetailImageWidthResizer("#adCreate");
                    console.log(mainDiv)
                }
                reader.readAsDataURL(this.files[i]);
            }
        }
    })
    $("#adEdit #add-photo #Car_DetailPhotos").change(function () {
        $("#adEdit .laterAdded").remove()
        let parentInput = $(this).parent();
        if (this.files) {
            for (i = 0; i < this.files.length; i++) {
                var reader = new FileReader();
                reader.onload = function (event) {
                    let mainDiv = document.createElement("div");
                    $(mainDiv).addClass("detail-image-single laterAdded");
                    let image = document.createElement("img");
                    $(image).attr('src', event.target.result).appendTo(mainDiv);
                    $(mainDiv).insertBefore(parentInput)
                    DetailImageWidthResizer("#adEdit");
                }

                reader.readAsDataURL(this.files[i]);
            }
        }
    })
    $("#blogCreate #add-photo #DetailPhotos").change(function () {
        $("#blogCreate .laterAdded").remove()
        let parentInput = $(this).parent();
        if (this.files) {
            for (i = 0; i < this.files.length; i++) {
                var reader = new FileReader();
                reader.onload = function (event) {
                    let mainDiv = document.createElement("div");
                    $(mainDiv).addClass("detail-image-single laterAdded");
                    let image = document.createElement("img");
                    $(image).attr('src', event.target.result).appendTo(mainDiv);
                    $(mainDiv).insertBefore(parentInput)
                    DetailImageWidthResizer("#blogCreate");
                }
                reader.readAsDataURL(this.files[i]);
            }
        }
    })
    $("#blogEdit #add-photo #DetailPhotos").change(function () {
        $("#blogEdit .laterAdded").remove()
        let parentInput = $(this).parent();
        if (this.files) {
            for (i = 0; i < this.files.length; i++) {
                var reader = new FileReader();
                reader.onload = function (event) {
                    let mainDiv = document.createElement("div");
                    $(mainDiv).addClass("detail-image-single laterAdded");
                    let image = document.createElement("img");
                    $(image).attr('src', event.target.result).appendTo(mainDiv);
                    $(mainDiv).insertBefore(parentInput)
                    DetailImageWidthResizer("#blogEdit");
                }

                reader.readAsDataURL(this.files[i]);
            }
        }
    })

    function DetailImageWidthResizer(section) {
        let singleImgWidth;
        if (window.innerWidth > 992) {
            singleImgWidth = ($(`${section} #detailImages`).width() / 4)
        }
        else {
            singleImgWidth = ($(`${section} #detailImages`).width() / 3)
        }
        $(`${section} #detailImages .detail-image-single`).width(singleImgWidth - 10)
    }
 })

//ad edit page select values
$(document).ready(function () {
    $("#adEdit #countries").change(function () {
        CityUpdater($(this).val(), "#adEdit")
    })
    $("#adEdit #brands").change(function () {
        ModelUpdater($(this).val(), "#adEdit");
    })

    $("#adCreate #countries").change(function () {
        CityUpdater($(this).val(), "#adCreate")
    })
    $("#adCreate #brands").change(function () {
        ModelUpdater($(this).val(), "#adCreate");
    })

    function CityUpdater(countryId, section) {
        if (countryId == "") {
            $(`${section} #cities`).html("<option value=''>Select City</option>")
        }
        if (countryId) {
            $.ajax({
                url: "/ajax/LoadCitiesByCountryId?countryId=" + countryId,
                type: "GET",
                success: function (res) {
                    $(`${section} #cities`).html(res)
                    $(`${section} #cities`).prepend("<option value=''>Select City</option>")
                    $(`${section} #cities`).val("")
                }
            });
        }
    }
    function ModelUpdater(brandId, section) {
        if (brandId == "") {
            $(`${section} #models`).html("<option value=''>Select Model</option>")
        }
        if (brandId) {
            $.ajax({
                url: "/ajax/LoadModelsByBrandId?brandId=" + brandId,
                type: "GET",
                success: function (res) {
                    $(`${section} #models`).html(res)
                    $(`${section} #models`).prepend("<option value=''>Select Model</option>")
                    $(`${section} #models`).val("")
                }
            });
        }
    }
})

//ad crud blog crud main image changer
$(document).ready(function () {
    $("#adEdit .remove-image").click(function (e) {
        e.preventDefault();
        MainImageRemove(this)
    })
    $("#adCreate .remove-image").click(function (e) {
        e.preventDefault();
        MainImageRemove(this)
    })
    $("#blogCreate .remove-image").click(function (e) {
        e.preventDefault();
        MainImageRemove(this);
    })
    $("#blogEdit .remove-image").click(function (e) {
        e.preventDefault();
        MainImageRemove(this);
    })

    function MainImageRemove(button) {
        $(button).addClass("d-none");
        $(button).prev().addClass("d-none");
        $(button).next().removeClass("d-none");
        $(button).next().children("input").val("")
    }
    $("#adCreate #Car_Photo").change(function () {
        readURL(this, "#adCreate");
        $("#adCreate .remove-image").removeClass("d-none");
        $("#adCreate #mainIMG").removeClass("d-none");
        $(this).parent().addClass("d-none")
    })
    $("#blogCreate #MainPhoto").change(function () {
        readURL(this, "#blogCreate");
        $("#blogCreate .remove-image").removeClass("d-none");
        $("#blogCreate #mainIMG").removeClass("d-none");
        $(this).parent().addClass("d-none")
    })
    $("#blogEdit #MainPhoto").change(function () {
        readURL(this, "#blogEdit");
        $("#blogEdit .remove-image").removeClass("d-none");
        $("#blogEdit #mainIMG").removeClass("d-none");
        $(this).parent().addClass("d-none")
    })

    $("#adEdit #Car_Photo").change(function () {
        readURL(this, "#adEdit");
        $("#adEdit #mainIMG").removeClass("d-none")
        $("#adEdit #mainIMG").next().removeClass("d-none")
        $(this).parent().addClass("d-none")
    })

    function readURL(input, section) {
        if (input.files && input.files[0]) {
            var reader = new FileReader();

            reader.onload = function (e) {
                $(`${section} #mainIMG`).attr('src', e.target.result);
            }
            reader.readAsDataURL(input.files[0]);
        }
    }
})

//moderator ad details
$(document).ready(function () {
    $("#adDetails #question-btn").click(function (e) {
        e.preventDefault();
        $(this).next().addClass("d-flex")
        $(this).next().next().addClass("d-none")
    })
    $("#adDetails #cancel").click(function (e) {
        e.preventDefault();
        $(this).parent().removeClass("d-flex")
        $(this).parent().next().removeClass("d-none")
    })
})
$(document).ready(function () {
    $("#Cities #selectCountries").change(function () {
        let id = $(this).val();
        let input = $(this);
        $("#Cities #Load table").html("")
        $("#Cities #loader").addClass("d-flex");
        $(input).attr('disabled', 'disabled')
        $.ajax({
            url: "/ajax/LoadCitiesTable?id=" + id,
            type: "GET",
            success: function (res) {
                $("#Cities #Load").html("")
                $("#Cities #Load").html(res)
                $("#loader").removeClass("d-flex");
                $(input).removeAttr("disabled")
            }
        })
    });
    $("#Models #selectModels").change(function () {
        let id = $(this).val();
        let input = $(this);
        $("#Models #Load table").html("")
        $("#Models #loader").addClass("d-flex");
        $(input).attr('disabled', 'disabled')
        $.ajax({
            url: "/ajax/LoadModelsTable?id=" + id,
            type: "GET",
            success: function (res) {
                $("#Models #Load").html("")
                $("#Models #Load").html(res)
                $("#loader").removeClass("d-flex");
                $(input).removeAttr("disabled")
            }
        })
    });
})
$(document).ready(function () {
    $(document).on("click", "#moderators #block", function (e) {
        e.preventDefault();
        let moderatorId = $(this).attr("data-id");
        let tBody = $(this).parent().parent().parent()
        $.ajax({
            url: "/ajax/Moderators?moderatorId=" + moderatorId,
            type: "GET",
            success: function (res) {
                tBody.remove();
                $("#moderators").append(res)
            }
        })
    })

    $(document).on("click", "#moderators #un-block", function (e) {
        e.preventDefault();
        let moderatorId = $(this).attr("data-id");
        let tBody = $(this).parent().parent().parent()
        $.ajax({
            url: "/ajax/Moderators?moderatorId=" + moderatorId,
            type: "GET",
            success: function (res) {
                tBody.remove();
                $("#moderators").append(res)
            }
        })
    })
})
$(document).ready(function () {
    $(document).on("click", "#orders #accept", function (e) {
        e.preventDefault();
        $(this).addClass("d-none")
        $(this).next().removeClass("d-none").addClass("d-flex")
    })
})
$(document).ready(function () {
    let messageDiv = document.querySelector("#ModeratorChat .messages");
    messageDiv.scrollTop = messageDiv.scrollHeight
})
$(document).ready(function () {
    let taken = parseInt($("#Brands #takenBrands").val());
    $(document).on("click", "#Brands #loadBrands", function (e) {
        e.preventDefault();
        console.log(taken)
        let count = parseInt($("#Brands #count").val())
        $.ajax({
            url: "/ajax/LoadBrandsAdmin?skip=" + taken,
            type: "GET",
            success: function (res) {
                taken += 10;
                if (taken >= count) {
                    $("#Brands #loadBrands").remove();
                }
                $("#Brands table tbody").append(res)

            }
        })
    })

})
$(document).ready(function () {
    let taken = parseInt($("#Countries #takenCountries").val());
    $(document).on("click", "#Countries #loadCountries", function (e) {
        e.preventDefault();
        let count = parseInt($("#Countries #count").val())
        $.ajax({
            url: "/ajax/LoadCountriesAdmin?skip=" + taken,
            type: "GET",
            success: function (res) {
                taken += 10;
                if (taken >= count) {
                    $("#Countries #loadCountries").remove();
                }
                $("#Countries table tbody").append(res)

            }
        })
    })
})
