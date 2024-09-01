import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditionTagsComponent } from './edition-tags.component';

describe('EditionTagsComponent', () => {
  let component: EditionTagsComponent;
  let fixture: ComponentFixture<EditionTagsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [EditionTagsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(EditionTagsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
