(function ($) {
    function Cidade() {
        var $this = this;

        function initilizeModel() {
            $("#modal-action-cidade").on('loaded.bs.modal', function (e) {
            }).on('hidden.bs.modal', function (e) {
                $(this).removeData('bs.modal');
            });
        }
        $this.init = function () {
            initilizeModel();
        }
    }
    $(function () {
        var self = new Cidade();
        self.init();
    })
}(jQuery))
