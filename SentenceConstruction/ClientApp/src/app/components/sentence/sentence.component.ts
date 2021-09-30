import {Component, Inject, OnDestroy, OnInit} from '@angular/core';
import {Subject} from "rxjs";
import {SentenceService} from "../../services/sentence-service";
import {Sentence} from "../../models/sentence";

@Component({
  selector: 'sentence',
  templateUrl: './sentence.component.html'
})
export class SentenceComponent implements OnInit, OnDestroy {

  private unsubscribe$ = new Subject<void>();
  sentenceList: Sentence[];

  constructor(private sentenceService: SentenceService) {
  }

  ngOnInit() {
    this.sentenceService.getSentences()
      .subscribe(
      x => this.sentenceList = x
    )
  }

  ngOnDestroy() {
    this.unsubscribe$.next();
    this.unsubscribe$.complete();
  }
}

