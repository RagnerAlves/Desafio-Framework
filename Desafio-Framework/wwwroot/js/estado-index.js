(function ($) {
    function Estado() {
        var $this = this;

        function initilizeModel() {
            $("#modal-action-estado").on('loaded.bs.modal', function (e) {
            }).on('hidden.bs.modal', function (e) {
                $(this).removeData('bs.modal');
            });
        }
        $this.init = function () {
            initilizeModel();
        }
    }
    $(function () {
        var self = new Estado();
        self.init();
    })
}(jQuery))
