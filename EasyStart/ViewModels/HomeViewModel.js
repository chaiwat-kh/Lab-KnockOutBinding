function PersonViewModel(name) {
    var self = this;
    self.projectName = ko.observable(name);
    self.firstName = ko.observable("Bert");
    self.lastName = ko.observable("Bertington");
    self.email = ko.observable("ibon@gmail.com");
    self.password = ko.observable("");
}

function NewsViewModel(data) {   
    var self = this;
    self.id = ko.observable(data.Id);
    self.head = ko.observable(data.HeadText);
    self.detail = ko.observable(data.DetailText);
    self.img = ko.observable(data.Img);
    self.href = ko.observable(data.Href);
}

function viewModelContainer() {
    var self = this;
    self.name = ko.observable("xxxx");
    self.person = new PersonViewModel("Tiny Villa");
    self.news = ko.observableArray([]);

    // Operations
    self.printCheck = function () {
        var ps = self.person;
        ps.firstName("New Project Name");

        console.log(self.name + " " + self.person.firstName);

    }

//    self.addNews = function () {
//        self.news.push(new NewsViewModel(1, "head1", "detail1"));
//    }

    $.getJSON("/Home/GetData", null, function (data) {       
        var mappedNews = $.map(data, function (item) {
            
                return new NewsViewModel(item)
            });
        self.news(mappedNews);
    });
}

// Activates knockout.js
//ko.applyBindings(new viewModelContainer());