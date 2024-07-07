import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RelatedTagsComponent } from './related-tags.component';

describe('RelatedTagsComponent', () => {
  let component: RelatedTagsComponent;
  let fixture: ComponentFixture<RelatedTagsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [RelatedTagsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(RelatedTagsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
