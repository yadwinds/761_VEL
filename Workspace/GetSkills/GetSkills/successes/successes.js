$.widget("getskills.successBoard", {
    options: {
        photo: "",
        name: "",
        title: "",
        courses: ""
    },

    _create: function () {
        this.build();       
    },

    build: function () {
        this.picture = $("<img src=" + this.options.photo + ">")
            .addClass("ui-dialog-content ui-widget-content img-circle")
            .appendTo(this.element);


        this.name = $("<div>" + this.options.name + "</div>")
            .addClass("ui-dialog-content ui-widget-content name text-center")
            .appendTo(this.element);

        this.title = $("<div>" + this.options.title + "</div>")
            .addClass("ui-dialog-content ui-widget-content title text-center")
            .appendTo(this.element);

        $("<div>Expertise in:</div>")
            .addClass("ui-dialog-content ui-widget-content text-center")
            .appendTo(this.element);

        this.title = $("<div>" + this.options.courses + "</div>")
            .addClass("ui-dialog-content ui-widget-content courses text-center")
            .appendTo(this.element);
    }
});