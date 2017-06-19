(function () {
    var perfHub = $.connection.perfHub;
    $.connection.hub.logging = true;
    $.connection.hub.start().done(function () {
        console.log("connection started!");
    }).fail(function () {
        console.log("connection start failed!!");
        });
    var content = $('#content').val();
    $('#send').click(function () {
        perfHub.server.send('ss','ffff');
    })

    //perfHub.client.newMessage = function (message) {
    //    model.addMessage(message);
    //};

    //var Model = function () {
    //    var self = this;
    //    self.message = ko.observable("");
    //    self.messages = ko.observableArray()
    //};
    //Model.prototype = {
    //    sendMessage: function () {
    //        var self = this;
    //        perfHub.server.send(self.message());
    //        self.message("");
    //    },
    //    addMessage: function (message) {
    //        var self = this;
    //        self.messages.push(message);
    //    }
    //};

    //var model = new Model();
    //$(function () {
    //    ko.applyBindings(model);
    //});



}())