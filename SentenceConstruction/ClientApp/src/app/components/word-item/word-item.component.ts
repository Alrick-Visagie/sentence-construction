import {Component, EventEmitter, Input, Output} from "@angular/core";

@Component({
  selector: 'word-item',
  template: `
            <span style="border: 1px solid #8e8e8e; margin-right: 5px; margin-bottom: 5px; border-radius: 10%; padding:1px; box-shadow: 0 0 40px "
                  (click)="wordSelected($event)">
              {{word}}
            </span>
  `
})

export class WordItemComponent{
  @Input() word: string;
  @Output() selectedWord = new EventEmitter<string>();

  wordSelected(clickEvent) {
    this.selectedWord.emit(clickEvent.target.innerText);
  }
}
