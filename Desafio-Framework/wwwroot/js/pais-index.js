﻿(function ($) {
    function Pais() {
        var $this = this;

        function initilizeModel() {
            $("#modal-action-pais").on('loaded.bs.modal', function (e) {
            }).on('hidden.bs.modal', function (e) {
                $(this).removeData('bs.modal');
            });
        }
        $this.init = function () {
            initilizeModel();
        }
    }
    $(function () {
        var self = new Pais();
        self.init();
    })
}(jQuery))
