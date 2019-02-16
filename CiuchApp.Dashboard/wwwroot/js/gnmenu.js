/**
 * gnmenu.js v1.0.0
 * http://www.codrops.com
 *
 * Licensed under the MIT license.
 * http://www.opensource.org/licenses/mit-license.php
 * 
 * Copyright 2013, Codrops
 * http://www.codrops.com
 */
; (function (window) {

    'use strict';

    // http://stackoverflow.com/a/11381730/989439
    function mobilecheck() {
        var check = false;
        (function (a) { if (/(android|ipad|playbook|silk|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows (ce|phone)|xda|xiino/i.test(a) || /1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-/i.test(a.substr(0, 4))) check = true })(navigator.userAgent || navigator.vendor || window.opera);
        return check;
    }

    function gnMenu(el, options) {
        this.el = el;
        this._init();
    }

    gnMenu.prototype = {
        _init: function () {
            this.mainMenuTrigger = this.el.querySelector('a.ciuchapp-menu-icon');
            this.mainMenu = this.el.querySelector('nav.gn-menu-wrapper');
            this.isMainMenuOpen = false;

            this.settingsSubmenuTrigger = this.el.querySelector('#gn-settings-menu .trigger');
            this.settingsSubmenu = this.el.querySelector('#gn-settings-menu .gn-submenu');
            this.isSettingsMenuOpen = false;

            this.piecesSubmenuTrigger = this.el.querySelector('#gn-pieces-menu .trigger');
            this.piecesSubmenu = this.el.querySelector('#gn-pieces-menu .gn-submenu');
            this.isPiecesMenuOpen = false;

            //LS: object that should change padding left;
            this.header = this.el.querySelector('header');
            this.eventtype = mobilecheck() ? 'touchstart' : 'click';
            var self = this;

            this._initEvents();

            // LS: body should not close sidebar
            // this.bodyClickFn = function() {
            // 	self._closeMenu();
            // 	this.removeEventListener( self.eventtype, self.bodyClickFn );
            // };

            // LS: sidebar should be open by default
            this._openMainMenu();

        },
        _initEvents: function () {
            var self = this;

            if (!mobilecheck()) {
                // this.trigger.addEventListener( 'mouseover', function(ev) { self._openIconMenu(); } );
                // this.trigger.addEventListener( 'mouseout', function(ev) { self._closeIconMenu(); } );

                this.mainMenu.addEventListener('mouseover', function (ev) {
                    self._openMainMenu();
                    document.addEventListener(self.eventtype, self.bodyClickFn);
                });
            }
            this.mainMenuTrigger.addEventListener(this.eventtype, function (ev) {
                ev.stopPropagation();
                ev.preventDefault();
                if (self.isMainMenuOpen) {
                    self._closeMainMenu();
                    document.removeEventListener(self.eventtype, self.bodyClickFn);
                }
                else {
                    self._openMainMenu();
                    document.addEventListener(self.eventtype, self.bodyClickFn);
                }
            });
            this.mainMenuTrigger.addEventListener(this.eventtype, function (ev) { ev.stopPropagation(); });

            this.settingsSubmenuTrigger.addEventListener(this.eventtype, function (ev) {
                ev.stopPropagation();
                ev.preventDefault();
                if (self.isSettingsMenuOpen) {
                    self._closeSettingsMenu();
                    document.removeEventListener(self.eventtype, self.bodyClickFn);
                }
                else {
                    self._openSettingsMenu();
                    document.addEventListener(self.eventtype, self.bodyClickFn);
                }
            });

            this.piecesSubmenuTrigger.addEventListener(this.eventtype, function (ev) {
                ev.stopPropagation();
                ev.preventDefault();
                if (self.isPiecesMenuOpen) {
                    self._closePiecesMenu();
                    document.removeEventListener(self.eventtype, self.bodyClickFn);
                }
                else {
                    self._openPiecesMenu();
                    document.addEventListener(self.eventtype, self.bodyClickFn);
                }
            });

        },

        // LS: do not use IconManu at all
        // _openIconMenu : function() {
        // 	classie.add( this.menu, 'gn-open-part' );
        // },
        // _closeIconMenu : function() {
        // 	classie.remove( this.menu, 'gn-open-part' );
        // },
        _openMainMenu: function () {
            if (this.isMainMenuOpen) return;
            classie.add(this.mainMenuTrigger, 'gn-selected');
            this.isMainMenuOpen = true;
            classie.add(this.mainMenu, 'gn-open-all');
            // this._closeIconMenu();
            classie.add(this.header, 'with-padding')
        },
        _closeMainMenu: function () {
            if (!this.isMainMenuOpen) return;
            classie.remove(this.mainMenu, 'gn-selected');
            this.isMainMenuOpen = false;
            classie.remove(this.mainMenu, 'gn-open-all');
            // this._closeIconMenu();
            classie.remove(this.header, 'with-padding')
        },
        ///////////////////////////////////
        _openSettingsMenu: function () {
            if (this.isSettingsMenuOpen) return;
            classie.add(this.settingsSubmenu, 'gn-open');
            this.isSettingsMenuOpen = true;
        },
        _closeSettingsMenu: function () {
            if (!this.isSettingsMenuOpen) return;
            classie.remove(this.settingsSubmenu, 'gn-open');
            this.isSettingsMenuOpen = false;
        },
        ////////////////////////////////
        _openPiecesMenu: function () {
            if (this.isPiecesMenuOpen) return;
            classie.add(this.piecesSubmenu, 'gn-open');
            this.isPiecesMenuOpen = true;
        },
        _closePiecesMenu: function () {
            if (!this.isPiecesMenuOpen) return;
            classie.remove(this.piecesSubmenu, 'gn-open');
            this.isPiecesMenuOpen = false;
        }
    }

    // add to global namespace
    window.gnMenu = gnMenu;

})(window);