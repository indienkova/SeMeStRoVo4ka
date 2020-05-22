import {Component, Input} from "@angular/core";

@Component({
  selector: 'app-message-component',
  templateUrl: './message.component.html'
})
export class MessageComponent {
  @Input() message;
}
