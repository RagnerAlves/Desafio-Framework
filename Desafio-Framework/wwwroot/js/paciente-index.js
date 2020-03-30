(function ($) {
    function Paciente() {
        var $this = this;

        function initilizeModel() {
            $("#modal-action-paciente").on('loaded.bs.modal', function (e) {
            }).on('hidden.bs.modal', function (e) {
                $(this).removeData('bs.modal');
            });
        }
        $this.init = function () {
            initilizeModel();
        }
    }
    $(function () {
        var self = new Paciente();
        self.init();
    })
}(jQuery))
